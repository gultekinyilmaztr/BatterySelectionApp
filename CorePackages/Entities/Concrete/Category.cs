﻿namespace CorePackages.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
        //public CategoryFeature CategoryFeature { get; set; }
    }
}
