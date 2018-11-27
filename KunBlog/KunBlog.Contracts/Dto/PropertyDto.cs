using System;
using System.Collections.Generic;

namespace KunBlog.Contracts.Dto
{
    public class PropertyDto : BaseDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Sale { get; set; }

        public int Bedroom { get; set; }

        public int Bathroom { get; set; }

        public decimal Area { get; set; }

        public List<PropertyImageDto> PropertyImage { get; set; }
    }
}
