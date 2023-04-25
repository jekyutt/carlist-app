using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SemestriProject.Data.Common;
using SemestriProject.Domain.Common;

namespace SemestriProject.Infra.Common
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, IFiltering
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()
    {
        public string SearchString { get; set; }
        public string FixedFilter { get; set; }
        public string FixedValue { get; set; }

        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public override IQueryable<TData> createSqlQuery()
        {
            var query = base.createSqlQuery();
            query = addFiltering(query);
            query = addFixedFiltering(query);

            return query;
        }

        public IQueryable<TData> addFixedFiltering(IQueryable<TData> query)
        {
            var expression = createFixedWhereExpression();
            return expression is null ? query: query.Where(expression);
        }

        public Expression<Func<TData, bool>> createFixedWhereExpression()
        {
            if (string.IsNullOrWhiteSpace(FixedValue)) return null;
            if (string.IsNullOrWhiteSpace(FixedFilter)) return null;
            var param = Expression.Parameter(typeof(TData), "s");

            var p = typeof(TData).GetProperty(FixedFilter);

            if (p is null) return null;
            Expression body = Expression.Property(param, p);
            if (p.PropertyType != typeof(string)) 
                body = Expression.Call(body, "ToString", null);
            body = Expression.Call(body, "Contains", null, Expression.Constant(FixedValue));
            var predicate = body;

            return Expression.Lambda<Func<TData, bool>>(predicate, param);
        }

        public IQueryable<TData> addFiltering(IQueryable<TData> query)
        {
            if (string.IsNullOrEmpty(SearchString)) return query;
            var expression = createWhereExpression();

            return expression is null ? query : query.Where(expression);
        }

        public Expression<Func<TData, bool>> createWhereExpression()
        {
            if (string.IsNullOrWhiteSpace(SearchString)) return null;
            var param = Expression.Parameter(typeof(TData), "s");

            Expression predicate = null;

            foreach (var p in typeof(TData).GetProperties())
            {
                Expression body = Expression.Property(param, p);
                if (p.PropertyType != typeof(string))
                    body = Expression.Call(body, "ToString", null);
                body = Expression.Call(body, "Contains", null, Expression.Constant(SearchString));
                predicate = predicate is null ? body : Expression.Or(predicate, body);
            }

            return predicate is null ? null : Expression.Lambda<Func<TData, bool>>(predicate, param);
        }
    }
}