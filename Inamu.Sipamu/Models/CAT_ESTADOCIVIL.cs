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
    
    public partial class CAT_ESTADOCIVIL
    {
        public CAT_ESTADOCIVIL()
        {
            this.CAT_PERSONA = new HashSet<CAT_PERSONA>();
        }
    
        public int I_IDESTADOCIVIL { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual ICollection<CAT_PERSONA> CAT_PERSONA { get; set; }
    }
}
