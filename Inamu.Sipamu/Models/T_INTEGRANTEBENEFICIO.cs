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
    
    public partial class T_INTEGRANTEBENEFICIO
    {
        public int I_IDBENEFICIO { get; set; }
        public int I_IDINTEGRANTE { get; set; }
        public double F_MONTO { get; set; }
    
        public virtual CAT_BENEFICIO CAT_BENEFICIO { get; set; }
        public virtual T_INTEGRANTEGRUPOFAMILIAR T_INTEGRANTEGRUPOFAMILIAR { get; set; }
    }
}
