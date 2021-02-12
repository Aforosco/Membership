
using Membership1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using Membership1.Models;
using Membership1.Areas.Admin.Models;

namespace Membership1.Extensions
{
    public static class ConversionExtension
    {
        public static async Task<IEnumerable<ProductModel>> Convert( this IEnumerable<Product>products, ApplicationDbContext db)
        {
            if (products.Count().Equals(0)) return new List<ProductModel>();
            var texts = await db.ProductLinkTexts.ToListAsync();
            var types = await db.ProductTypes.ToListAsync();

            return from p in products
                   select new ProductModel
                   {
                       Id = p.Id,
                       Title = p.Title,
                       ImageUrl = p.ImageUrl,
                       ProductTypeId= p.ProductTypeId,
                       Description =p.Description,
                       ProductLinkTextId =p.ProductLinkTextId,
                       ProductTypes = types,
                       ProductLinkTexts = texts

                   };
        }
    }
}