//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Traffic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trips
    {
        public long tripID { get; set; }
        public long organizationID { get; set; }
        public string tableNumber { get; set; }
        public Nullable<long> tripNumber { get; set; }
        public Nullable<System.DateTime> dateFrom { get; set; }
        public Nullable<System.DateTime> dateUntil { get; set; }
        public Nullable<long> ATS { get; set; }
        public Nullable<decimal> beltoll { get; set; }
        public Nullable<decimal> salaryRate { get; set; }
        public Nullable<decimal> fuelPerOneKm { get; set; }
        public Nullable<decimal> tonnageRate { get; set; }
        public Nullable<decimal> fuelPricePerOneLitre { get; set; }
        public Nullable<decimal> adblue { get; set; }
        public Nullable<decimal> tripExpences { get; set; }
    }
}
