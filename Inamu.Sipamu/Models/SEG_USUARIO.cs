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
    
    public partial class SEG_USUARIO
    {
        public SEG_USUARIO()
        {
            this.T_BITACORA = new HashSet<T_BITACORA>();
            this.T_ERROR = new HashSet<T_ERROR>();
        }
    
        public int I_IDUSUARIO { get; set; }
        public Nullable<int> I_IDPERSONA { get; set; }
        public Nullable<int> I_IDPERFIL { get; set; }
        public string VC_LOGIN { get; set; }
        public string VC_CONTRASENNA { get; set; }
    
        public virtual CAT_PERSONA CAT_PERSONA { get; set; }
        public virtual SEG_PERFIL SEG_PERFIL { get; set; }
        public virtual ICollection<T_BITACORA> T_BITACORA { get; set; }
        public virtual ICollection<T_ERROR> T_ERROR { get; set; }
    }
}
