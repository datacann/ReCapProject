using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {     
            public static string CarAdded = "Araba eklendi";
            public static string CarDeleted = "Araba silindi";
            public static string CarUpdated = "Araba güncellendi";
            public static string CarsListed = "Arabalar listelendi";
            public static string CarNameInvalid = "Araba ismi geçersiz";

            public static string MaintenanceTime = "Sistem bakımda";

            public static string ColorAdded = "Renk eklendi";
            public static string ColorDeleted = "Renk silindi";
            public static string ColorUpdated = "Renk güncellendi";
            public static string ColorsListed = "Renkler listelendi";

            public static string BrandAdded = "Marka eklendi";
            public static string BrandDeleted = "Marka silindi";
            public static string BrandUpdated = "Marka güncellendi";
            public static string BrandsListed = "Markalar listelendi";
            public static string BrandNameInvalid = "Marka ismi geçersiz";

            internal static string UserDeleted= "kullanıcı silindi";
            internal static string UserAdded="kullanıcı eklendi";
        internal static string UserUpdated= "kullanıcı güncellendi";

        internal static string CustomerDeleted= "müşteri silindi";
        internal static string CustomerListed= "müşteri listelendi";


        internal static string CustomerAdded = "müşteri eklendi";
           internal static string CustomerUpdated= "müşteri güncellendi";

        internal static string RentalNotAvailable= "araç uygun değil";
        internal static string SuccessRentCar= "başarılı kiralama";
        internal static string RentalDeleted= "araç kiralama işlemi silindi";
        internal static string RentalUpdated= "araç güncellendi";
        internal static string ReturnDateNotNull = "araç kiralama tarihi dolu";
        internal static string RentalAdded = "araç kiralama işlemi eklendi";
    }
}
