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
    
    public partial class CAT_LENGUA
    {
        public CAT_LENGUA()
        {
            this.T_PARTICIPANTE = new HashSet<T_PARTICIPANTE>();
        }
    
        public int I_IDLENGUA { get; set; }
        public string CV_DESCRIPCION { get; set; }
    
        public virtual ICollection<T_PARTICIPANTE> T_PARTICIPANTE { get; set; }
    }
}
