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
    
    public partial class CAT_RECURSOSCUMPLIRINTERES
    {
        public CAT_RECURSOSCUMPLIRINTERES()
        {
            this.T_PLANEDUCACIONTECNICA = new HashSet<T_PLANEDUCACIONTECNICA>();
            this.T_PLANEDUCACIONFORMAL = new HashSet<T_PLANEDUCACIONFORMAL>();
            this.T_PLANEMPLEABILIDAD = new HashSet<T_PLANEMPLEABILIDAD>();
            this.T_PLANOTROS = new HashSet<T_PLANOTROS>();
            this.T_PLANPROYECTOPRODUCTIVO = new HashSet<T_PLANPROYECTOPRODUCTIVO>();
            this.T_PLANSALUD = new HashSet<T_PLANSALUD>();
            this.T_PLANVIDAVIVIENDAACTUAL = new HashSet<T_PLANVIDAVIVIENDAACTUAL>();
        }
    
        public int I_IDRECURSOCUMPLIRINTERES { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual ICollection<T_PLANEDUCACIONTECNICA> T_PLANEDUCACIONTECNICA { get; set; }
        public virtual ICollection<T_PLANEDUCACIONFORMAL> T_PLANEDUCACIONFORMAL { get; set; }
        public virtual ICollection<T_PLANEMPLEABILIDAD> T_PLANEMPLEABILIDAD { get; set; }
        public virtual ICollection<T_PLANOTROS> T_PLANOTROS { get; set; }
        public virtual ICollection<T_PLANPROYECTOPRODUCTIVO> T_PLANPROYECTOPRODUCTIVO { get; set; }
        public virtual ICollection<T_PLANSALUD> T_PLANSALUD { get; set; }
        public virtual ICollection<T_PLANVIDAVIVIENDAACTUAL> T_PLANVIDAVIVIENDAACTUAL { get; set; }
    }
}
