//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFPata
{
    using System;
    using System.Collections.Generic;
    
    public partial class Terapeuta
    {
        public Terapeuta()
        {
            this.Paciente = new HashSet<Paciente>();
        }
    
        public int Id { get; set; }
        public string nome { get; set; }
        public string cc { get; set; }
        public string telefone { get; set; }
        public System.DateTime dataNasc { get; set; }
    
        public virtual Conta Conta { get; set; }
        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}