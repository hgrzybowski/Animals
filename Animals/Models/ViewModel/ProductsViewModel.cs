using System.Collections.Generic;

namespace Animals.Models.ViewModel
{
    public class ProductsViewModel
    {
        public Products Products { get; set; }
        public IEnumerable<ProductTypes> Race { get; set; }
        public IEnumerable<SpecialTags> Features { get; set; }

    }
}
