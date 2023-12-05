namespace CorePackages.Entities.Concrete
{
    public class ProductFeature : BaseEntity
    {
        //public int Id { get; set; }
        public double Icdeger { get; set; }
        public double Gerilim { get; set; }
        public bool Durum { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
