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
    
    public partial class CAT_RIESGOVIVIENDA
    {
        public CAT_RIESGOVIVIENDA()
        {
            this.T_PARTICIPANTECONDICIONESVIDA = new HashSet<T_PARTICIPANTECONDICIONESVIDA>();
            this.T_PARTICIPANTE = new HashSet<T_PARTICIPANTE>();
        }
    
        public int I_IDRIESGO { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual ICollection<T_PARTICIPANTECONDICIONESVIDA> T_PARTICIPANTECONDICIONESVIDA { get; set; }
        public virtual ICollection<T_PARTICIPANTE> T_PARTICIPANTE { get; set; }
    }
}
