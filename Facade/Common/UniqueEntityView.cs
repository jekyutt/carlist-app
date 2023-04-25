using System.ComponentModel.DataAnnotations;

namespace SemestriProject.Facade.Common
{
    public abstract class UniqueEntityView : PeriodView
    {
        [Required]
        public virtual string Id { get; set; }
    }
}