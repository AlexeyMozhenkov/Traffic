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
    
    public partial class Organization
    {
        public Organization()
        {
            this.Employee = new HashSet<Employee>();
        }
    
        public long addressID { get; set; }
        public long organizationID { get; set; }
        public string FullTitle { get; set; }
        public string ShortTitle { get; set; }
        public string RegistrationNumber { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string UNP { get; set; }
    
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
