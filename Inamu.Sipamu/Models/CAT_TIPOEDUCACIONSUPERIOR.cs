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
    
    public partial class CAT_TIPOEDUCACIONSUPERIOR
    {
        public CAT_TIPOEDUCACIONSUPERIOR()
        {
            this.T_PARTICIPANTEEDUCACIONFORMAL = new HashSet<T_PARTICIPANTEEDUCACIONFORMAL>();
        }
    
        public int I_IDTIPOEDUCACIONSUPERIOR { get; set; }
        public string VC_DESCRIPCION { get; set; }
    
        public virtual ICollection<T_PARTICIPANTEEDUCACIONFORMAL> T_PARTICIPANTEEDUCACIONFORMAL { get; set; }
    }
}
