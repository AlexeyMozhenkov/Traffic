﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class trafficEntities : DbContext
    {
        public trafficEntities()
            : base("name=trafficEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Act> Act { get; set; }
        public virtual DbSet<ActPersons> ActPersons { get; set; }
        public virtual DbSet<ActTransportation> ActTransportation { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ContactPerson> ContactPerson { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<contractMaterialLiability> contractMaterialLiability { get; set; }
        public virtual DbSet<ContractPersons> ContractPersons { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<ContractStreak> ContractStreak { get; set; }
        public virtual DbSet<ContractTransportation> ContractTransportation { get; set; }
        public virtual DbSet<DrivingLicence> DrivingLicence { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<InternationalCard> InternationalCard { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesActs> ServicesActs { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TechnicalInspection> TechnicalInspection { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<transportStateReport> transportStateReport { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }
        public virtual DbSet<TypeCost> TypeCost { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
