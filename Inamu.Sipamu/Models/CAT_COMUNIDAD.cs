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
    
    public partial class CAT_COMUNIDAD
    {
        public CAT_COMUNIDAD()
        {
            this.T_GRUPO = new HashSet<T_GRUPO>();
            this.T_LOCALIZACIONPARTICIPANTE = new HashSet<T_LOCALIZACIONPARTICIPANTE>();
        }
    
        public int I_IDCOMUNIDAD { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual ICollection<T_GRUPO> T_GRUPO { get; set; }
        public virtual ICollection<T_LOCALIZACIONPARTICIPANTE> T_LOCALIZACIONPARTICIPANTE { get; set; }
    }
}
