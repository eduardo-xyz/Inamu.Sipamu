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
    
    public partial class CAT_ETNIA
    {
        public CAT_ETNIA()
        {
            this.CAT_PERSONA = new HashSet<CAT_PERSONA>();
            this.T_PARTICIPANTE = new HashSet<T_PARTICIPANTE>();
        }
    
        public int I_IDETNIA { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual ICollection<CAT_PERSONA> CAT_PERSONA { get; set; }
        public virtual ICollection<T_PARTICIPANTE> T_PARTICIPANTE { get; set; }
    }
}
