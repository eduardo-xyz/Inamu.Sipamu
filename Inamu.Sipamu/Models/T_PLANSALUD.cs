//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inamu.Sipamu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PLANSALUD
    {
        public int I_IDPLANSALUD { get; set; }
        public Nullable<int> I_IDRECURSOCUMPLIRINTERES { get; set; }
        public Nullable<int> I_IDINSTITUCIONCUMPLIRINTERES { get; set; }
        public Nullable<int> I_IDPARTICIPANTE { get; set; }
        public string VC_DESCRIPCION { get; set; }
        public string VC_RECURSOSCUMPLIRINTERES { get; set; }
        public Nullable<int> I_PRIORIDAD { get; set; }
    
        public virtual CAT_INSTITUCIONCUMPLIRINTERES CAT_INSTITUCIONCUMPLIRINTERES { get; set; }
        public virtual CAT_RECURSOSCUMPLIRINTERES CAT_RECURSOSCUMPLIRINTERES { get; set; }
        public virtual T_PARTICIPANTE T_PARTICIPANTE { get; set; }
    }
}
