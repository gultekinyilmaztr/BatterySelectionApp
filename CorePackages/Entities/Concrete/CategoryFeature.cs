namespace CorePackages.Entities.Concrete
{
    public class CategoryFeature : BaseEntity
    {
        //public int Id { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Weight { get; set; }

        public Category Category { get; set; }

    }
}
