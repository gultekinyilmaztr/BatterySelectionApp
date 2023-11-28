namespace Battery.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string CellSerialNo { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
