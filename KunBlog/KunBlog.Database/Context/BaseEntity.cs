using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KunBlog.Database.Context
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
