using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string ProductNameAlreadyExist="Bu isimde bir ürün zaten mevcut";
        public static string OverCategoryCount="Kategori sayısı 15'i geçti";
        public static string AuthorizationDenied= "You are not authorized";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Wrong password";
        public static string SuccessfulLogin = "Login is successfully";
        public static string UserAlreadyExists = "This user name already exist";
        public static string UserRegistered = "User created successfully";
        public static string AccessTokenCreated = "Access token created successfully";
        public static string ProductUpdated="Product updated";
    }
}
