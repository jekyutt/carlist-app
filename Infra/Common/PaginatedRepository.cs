using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SemestriProject.Data.Common;
using SemestriProject.Domain.Common;

namespace SemestriProject.Infra.Common
{
    public abstract class PaginatedRepository<TDomain, TData> : FilteredRepository<TDomain, TData>, IPaging
        where TData : PeriodData, new()
    where TDomain : Entity<TData>, new()
    {
        public int PageIndex { get; set; }
        public int TotalPages => getTotalPages(PageSize);
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
        public int PageSize { get; set; } = 25;

        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public int getTotalPages(in int pageSize)
        {
            var count = getItemsCount();
            var pages = countTotalPages(count, pageSize);
            return pages;
        }

        public int countTotalPages(int count, in int pageSize) => (int)Math.Ceiling(count / (double)pageSize);

        public int getItemsCount() => base.createSqlQuery().CountAsync().Result;

        public override IQueryable<TData> createSqlQuery() => addSkipAndTake(base.createSqlQuery());

        public IQueryable<TData> addSkipAndTake(IQueryable<TData> query)
        {
            if (PageIndex < 1) return query;
            return query
                    .Skip((PageIndex - 1) * PageSize)
                    .Take(PageSize);
        }
    }
}