using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "System is in maintenance now";
        public static string ProductsListed = "Products is listed";
        public static string ProductCountCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist="Bu isimde bir ünün mevcut";
        internal static string OverCategoryCount="Kategori sayısı 15'i geçti";
    }
}
