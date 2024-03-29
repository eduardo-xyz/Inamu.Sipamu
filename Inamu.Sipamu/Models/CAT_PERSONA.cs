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
    
    public partial class CAT_PERSONA
    {
        public CAT_PERSONA()
        {
            this.SEG_USUARIO = new HashSet<SEG_USUARIO>();
            this.T_GRUPO = new HashSet<T_GRUPO>();
            this.T_INTEGRANTEGRUPOFAMILIAR = new HashSet<T_INTEGRANTEGRUPOFAMILIAR>();
            this.T_PARTICIPANTE = new HashSet<T_PARTICIPANTE>();
            this.T_SEGUIMIENTOPLANVIDA = new HashSet<T_SEGUIMIENTOPLANVIDA>();
        }
    
        public int I_IDPERSONA { get; set; }
        public Nullable<int> I_IDCOMUNIDAD { get; set; }
        public Nullable<int> I_IDESTADOCIVIL { get; set; }
        public Nullable<int> I_IDPAIS { get; set; }
        public Nullable<int> I_IDSEXO { get; set; }
        public Nullable<int> I_IDTIPOIDENTIFICACION { get; set; }
        public Nullable<int> I_IDREGION { get; set; }
        public Nullable<int> I_IDETNIA { get; set; }
        public Nullable<int> I_IDCANTON { get; set; }
        public Nullable<int> I_IDPROVINCIA { get; set; }
        public Nullable<int> I_IDDISTRITO { get; set; }
        public Nullable<int> I_IDNACIONALIDAD { get; set; }
        public string VC_IDENTIFICACION { get; set; }
        public Nullable<System.DateTime> DT_IDENTIFICACIONVENCIMIENTO { get; set; }
        public string VC_NOMBRE { get; set; }
        public string VC_PRIMERAPELLIDO { get; set; }
        public string VC_SEGUNDOAPELLIDO { get; set; }
        public Nullable<System.DateTime> DT_FECHANACIMIENTO { get; set; }
        public string VC_CONOCIDOCOMO { get; set; }
        public string VC_OBSERVACIONESESTADOCIVIL { get; set; }
    
        public virtual CAT_CANTON CAT_CANTON { get; set; }
        public virtual CAT_DISTRITO CAT_DISTRITO { get; set; }
        public virtual CAT_ESTADOCIVIL CAT_ESTADOCIVIL { get; set; }
        public virtual CAT_ETNIA CAT_ETNIA { get; set; }
        public virtual CAT_PAIS CAT_PAIS { get; set; }
        public virtual CAT_PROVINCIA CAT_PROVINCIA { get; set; }
        public virtual CAT_REGION CAT_REGION { get; set; }
        public virtual CAT_SEXO CAT_SEXO { get; set; }
        public virtual CAT_TIPOIDENTIFICACION CAT_TIPOIDENTIFICACION { get; set; }
        public virtual ICollection<SEG_USUARIO> SEG_USUARIO { get; set; }
        public virtual ICollection<T_GRUPO> T_GRUPO { get; set; }
        public virtual ICollection<T_INTEGRANTEGRUPOFAMILIAR> T_INTEGRANTEGRUPOFAMILIAR { get; set; }
        public virtual ICollection<T_PARTICIPANTE> T_PARTICIPANTE { get; set; }
        public virtual ICollection<T_SEGUIMIENTOPLANVIDA> T_SEGUIMIENTOPLANVIDA { get; set; }
    }
}
