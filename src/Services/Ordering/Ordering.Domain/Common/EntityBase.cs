using System;

namespace Ordering.Domain.Common
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public string CreadtedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
