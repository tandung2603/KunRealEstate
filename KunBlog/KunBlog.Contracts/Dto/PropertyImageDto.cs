using System;

namespace KunBlog.Contracts.Dto
{
    public class PropertyImageDto : BaseDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public PropertyDto Property { get; set; }
    }
}
