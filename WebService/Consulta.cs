//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Consulta
    {
        public Consulta()
        {
            this.Medicacao = new HashSet<Medicacao>();
            this.Sintomas = new HashSet<Sintomas>();
            this.Diagnosticos = new HashSet<Diagnosticos>();
        }
    
        public int Id { get; set; }
        public System.DateTime data { get; set; }
        public string diagnostico { get; set; }
    
        public virtual Utente Utente { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual ICollection<Medicacao> Medicacao { get; set; }
        public virtual ICollection<Sintomas> Sintomas { get; set; }
        public virtual ICollection<Diagnosticos> Diagnosticos { get; set; }
    }
}
