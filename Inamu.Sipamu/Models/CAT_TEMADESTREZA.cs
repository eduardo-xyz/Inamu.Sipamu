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
    
    public partial class CAT_TEMADESTREZA
    {
        public CAT_TEMADESTREZA()
        {
            this.T_PLANEDUCACIONTECNICA = new HashSet<T_PLANEDUCACIONTECNICA>();
        }
    
        public int I_IDTEMADESTREZA { get; set; }
        public string VC_TEMADESTREZA { get; set; }
    
        public virtual ICollection<T_PLANEDUCACIONTECNICA> T_PLANEDUCACIONTECNICA { get; set; }
    }
}
