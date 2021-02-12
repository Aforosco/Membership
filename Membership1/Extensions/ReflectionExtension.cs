using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Membership1.Extensions
{
    public  static class ReflectionExtension
    {
        public static string GetPropertyValue<T>( this T item, String propertyName)
        {

            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();

        }
    }
}