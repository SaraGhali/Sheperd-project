using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sheperd.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }

    public class ProductMetaData
    {
        [Display(Name ="كود الصنف")]
        public int productId { get; set; }

       [Display(Name ="اسم الصنف")]
        public string productName { get; set; }

        [Display(Name = "سعر الشراء")]

        public Nullable<decimal> buyingPrice { get; set; }

        [Display(Name = "سعر البيع")]

        public Nullable<decimal> sellingPrice { get; set; }

        [Display(Name = "الكمية")]

        public Nullable<decimal> productQuantity { get; set; }

        [Display(Name ="وصف الصنف")]
        public string productDescription { get; set; }
        [Display(Name ="مكان الصنف")]
        public string productPlace { get; set; }


    }
}