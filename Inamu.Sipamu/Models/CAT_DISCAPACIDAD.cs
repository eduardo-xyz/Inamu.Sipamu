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
    
    public partial class CAT_DISCAPACIDAD
    {
        public CAT_DISCAPACIDAD()
        {
            this.T_INTEGRANTEGRUPOFAMILIAR = new HashSet<T_INTEGRANTEGRUPOFAMILIAR>();
        }
    
        public int I_IDDISCAPACIDAD { get; set; }
        public Nullable<int> I_IDTIPODISCAPACIDAD { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual CAT_TIPODISCAPACIDAD CAT_TIPODISCAPACIDAD { get; set; }
        public virtual ICollection<T_INTEGRANTEGRUPOFAMILIAR> T_INTEGRANTEGRUPOFAMILIAR { get; set; }
    }
}
