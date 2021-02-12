using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Membership1.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        [MaxLength(1024)]
        public string Url { get; set; }

        [DisplayName("Image URL")]
        [MaxLength(1024)]
        public string ImageUrl { get; set; }

        [AllowHtml]
        public string HTML { get; set; }

        [DisplayName("Wait Days")]
        [DefaultValue(0)]
        public int WaitDays { get; set; }

        [DisplayName("Html Short")]

        public string HtmlShort { get { return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50); }  }

        public int ProductId { get; set; }

        public int ItemTypeId { get; set; }

        public int SectionId { get; set; }

        public int PartId { get; set; }

        [DisplayName("Item Types")]

        public ICollection<ItemType>ItemTypes { get; set; }

        [DisplayName("Parts")]

        public ICollection<Part> Parts { get; set; }

        [DisplayName("Sections")]

        public ICollection<Section> Sections { get; set; }

        public bool isfree { get; set; }


    }
}