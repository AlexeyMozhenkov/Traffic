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
    
    public partial class ContractStreak
    {
        public long contractID { get; set; }
        public Nullable<System.DateTime> contractDateFrom { get; set; }
        public Nullable<long> ContractDateUntil { get; set; }
        public Nullable<decimal> contractPrice { get; set; }
    
        public virtual Contracts Contracts { get; set; }
    }
}