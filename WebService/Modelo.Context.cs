﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EinsteinHospitalBDEntities : DbContext
    {
        public EinsteinHospitalBDEntities()
            : base("name=EinsteinHospitalBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Utilizador> UtilizadorSet { get; set; }
        public virtual DbSet<Exame> ExameSet { get; set; }
        public virtual DbSet<Utente> UtenteSet { get; set; }
        public virtual DbSet<Consulta> ConsultaSet { get; set; }
        public virtual DbSet<Medicacao> MedicacaoSet { get; set; }
        public virtual DbSet<Sintomas> SintomasSet { get; set; }
    }
}