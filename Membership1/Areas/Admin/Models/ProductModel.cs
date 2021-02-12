using Membership1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Membership1.Areas.Admin.Models
{
    public class ProductModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }


        [MaxLength(2048)]
        public string Description { get; set; }

        [DisplayName("Image Url")]
        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        
        public int ProductLinkTextId { get; set; }

        public int ProductTypeId { get; set; }

        [DisplayName("Product Link Texts")]
        public ICollection<ProductLinkText>ProductLinkTexts { get; set; }

        [DisplayName("Product Types")]
        public ICollection<ProductType> ProductTypes { get; set; }

        public string ProductType
        {
            get
            {
                return ProductTypes == null || ProductTypes.Count.Equals(0) ?
                            string.Empty : ProductTypes.First(pt => pt.Id.Equals(ProductTypeId)).Title;
            }

        }
             public string ProductLinkText
        {
            get
            {
                return ProductLinkTexts == null || ProductLinkTexts.Count.Equals(0) ?
                            string.Empty : ProductLinkTexts.First(pt => pt.Id.Equals(ProductLinkTexts)).Title;
            }
        }

    }
}