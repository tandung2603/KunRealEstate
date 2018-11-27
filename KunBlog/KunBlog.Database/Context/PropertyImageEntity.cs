namespace KunBlog.Database.Context
{
    public class PropertyImageEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public PropertyEntity Property { get; set; }
    }
}
