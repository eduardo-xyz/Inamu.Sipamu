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
    
    public partial class T_EVENTOBITACORA
    {
        public T_EVENTOBITACORA()
        {
            this.T_BITACORA = new HashSet<T_BITACORA>();
        }
    
        public int I_IDEVENTOBITACORA { get; set; }
        public string CV_DESCRIPCION { get; set; }
    
        public virtual ICollection<T_BITACORA> T_BITACORA { get; set; }
    }
}
