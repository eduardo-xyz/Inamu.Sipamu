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
    
    public partial class T_PARTICIPANTEVIVIENDA
    {
        public int I_ID_VIVIENDA { get; set; }
        public Nullable<int> I_IDTIPOTENENCIA { get; set; }
        public Nullable<int> I_IDTIPOBONO { get; set; }
        public Nullable<int> I_IDTIPOVIVIENDA { get; set; }
        public Nullable<int> I_IDTIPOTECHOVIVIENDA { get; set; }
        public Nullable<int> I_IDTIPOCIELORASO { get; set; }
        public Nullable<int> I_IDPARTICIPANTEPROPIEDAD { get; set; }
        public Nullable<int> I_IDJEFEHOGARPROPIEDAD { get; set; }
        public Nullable<int> I_IDPARTICIPANTE { get; set; }
        public Nullable<int> I_IDTIPOPISOVIVIENDA { get; set; }
        public Nullable<int> I_IDTIPOPARED { get; set; }
        public Nullable<bool> B_HABITAVIVIENDABONO { get; set; }
        public string VC_MOTIVONOHABITAVIVIENDABONO { get; set; }
        public Nullable<bool> B_VIVIENDACOMPARTIDA { get; set; }
        public Nullable<bool> B_ESARRIMADO { get; set; }
        public Nullable<int> I_FAMILIASHABITANVIVIENDA { get; set; }
        public Nullable<int> I_DORMITORIO { get; set; }
        public Nullable<int> I_APOSENTO { get; set; }
        public Nullable<int> B_SANITARIODENTROVIVIENDA { get; set; }
        public Nullable<int> B_BANNODENTROVIVIENDA { get; set; }
        public Nullable<bool> B_SERVICIOELECTRICO { get; set; }
        public Nullable<bool> B_SERVICIOAGUA { get; set; }
    
        public virtual CAT_RESPUESTACORTA CAT_RESPUESTACORTA { get; set; }
        public virtual CAT_RESPUESTACORTA CAT_RESPUESTACORTA1 { get; set; }
        public virtual CAT_TIPOBONO CAT_TIPOBONO { get; set; }
        public virtual CAT_TIPOCIELORASO CAT_TIPOCIELORASO { get; set; }
        public virtual CAT_TIPOPARED CAT_TIPOPARED { get; set; }
        public virtual CAT_TIPOPISOVIVIENDA CAT_TIPOPISOVIVIENDA { get; set; }
        public virtual CAT_TIPOTECHOVIVIENDA CAT_TIPOTECHOVIVIENDA { get; set; }
        public virtual CAT_TIPOTENENCIA CAT_TIPOTENENCIA { get; set; }
        public virtual CAT_TIPOVIVIENDA CAT_TIPOVIVIENDA { get; set; }
        public virtual T_PARTICIPANTE T_PARTICIPANTE { get; set; }
    }
}
