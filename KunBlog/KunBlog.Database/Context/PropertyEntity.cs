using System.Collections.Generic;

namespace KunBlog.Database.Context
{
    public class PropertyEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Sale { get; set; }

        public int Bedroom { get; set; }

        public int Bathroom { get; set; }

        public decimal Area { get; set; }

        public List<PropertyImageEntity> PropertyImage { get; set; }
    }
}
