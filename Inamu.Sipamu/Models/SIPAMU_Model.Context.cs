﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SIPAMU_Entities : DbContext
    {
        public SIPAMU_Entities()
            : base("name=SIPAMU_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CAT_APLICACIONESTUDIOTECNICO> CAT_APLICACIONESTUDIOTECNICO { get; set; }
        public DbSet<CAT_BENEFICIO> CAT_BENEFICIO { get; set; }
        public DbSet<CAT_CANTON> CAT_CANTON { get; set; }
        public DbSet<CAT_COMUNIDAD> CAT_COMUNIDAD { get; set; }
        public DbSet<CAT_CONDICIONESPECIAL> CAT_CONDICIONESPECIAL { get; set; }
        public DbSet<CAT_CONDICIONLABORAL> CAT_CONDICIONLABORAL { get; set; }
        public DbSet<CAT_CONDICIONLUGAR> CAT_CONDICIONLUGAR { get; set; }
        public DbSet<CAT_DIA> CAT_DIA { get; set; }
        public DbSet<CAT_DISCAPACIDAD> CAT_DISCAPACIDAD { get; set; }
        public DbSet<CAT_DISTRITO> CAT_DISTRITO { get; set; }
        public DbSet<CAT_ENFERMEDAD> CAT_ENFERMEDAD { get; set; }
        public DbSet<CAT_ESPECIALIDADEDUCATIVA> CAT_ESPECIALIDADEDUCATIVA { get; set; }
        public DbSet<CAT_ESTADO> CAT_ESTADO { get; set; }
        public DbSet<CAT_ESTADOCIVIL> CAT_ESTADOCIVIL { get; set; }
        public DbSet<CAT_ETNIA> CAT_ETNIA { get; set; }
        public DbSet<CAT_GRADOSEDUCACIONBASICA> CAT_GRADOSEDUCACIONBASICA { get; set; }
        public DbSet<CAT_GRADOSEDUCACIONSUPERIOR> CAT_GRADOSEDUCACIONSUPERIOR { get; set; }
        public DbSet<CAT_INSTITUCIONCUMPLIRINTERES> CAT_INSTITUCIONCUMPLIRINTERES { get; set; }
        public DbSet<CAT_INSTITUCIONEDUCATIVAACTUAL> CAT_INSTITUCIONEDUCATIVAACTUAL { get; set; }
        public DbSet<CAT_JORNADALABORAL> CAT_JORNADALABORAL { get; set; }
        public DbSet<CAT_LENGUA> CAT_LENGUA { get; set; }
        public DbSet<CAT_LUGARTRABAJO> CAT_LUGARTRABAJO { get; set; }
        public DbSet<CAT_MEDIOINFORMACION> CAT_MEDIOINFORMACION { get; set; }
        public DbSet<CAT_META> CAT_META { get; set; }
        public DbSet<CAT_MOTIVONOESTUDIA> CAT_MOTIVONOESTUDIA { get; set; }
        public DbSet<CAT_NECESIDADEDUCACIONFORMAL> CAT_NECESIDADEDUCACIONFORMAL { get; set; }
        public DbSet<CAT_NIVELAVANCE> CAT_NIVELAVANCE { get; set; }
        public DbSet<CAT_NIVELLECTOESCRITURA> CAT_NIVELLECTOESCRITURA { get; set; }
        public DbSet<CAT_OCUPACION> CAT_OCUPACION { get; set; }
        public DbSet<CAT_PAIS> CAT_PAIS { get; set; }
        public DbSet<CAT_PARENTESCO> CAT_PARENTESCO { get; set; }
        public DbSet<CAT_PARTICIPACIONCOMUNAL> CAT_PARTICIPACIONCOMUNAL { get; set; }
        public DbSet<CAT_PENSIONAPOYO> CAT_PENSIONAPOYO { get; set; }
        public DbSet<CAT_PERSONA> CAT_PERSONA { get; set; }
        public DbSet<CAT_PROGRAMA> CAT_PROGRAMA { get; set; }
        public DbSet<CAT_PROVINCIA> CAT_PROVINCIA { get; set; }
        public DbSet<CAT_PUEBLOINDIGENA> CAT_PUEBLOINDIGENA { get; set; }
        public DbSet<CAT_PUESTODIRECCIONLIDERAZGO> CAT_PUESTODIRECCIONLIDERAZGO { get; set; }
        public DbSet<CAT_RAMALABORAL> CAT_RAMALABORAL { get; set; }
        public DbSet<CAT_RECURSOSCUMPLIRINTERES> CAT_RECURSOSCUMPLIRINTERES { get; set; }
        public DbSet<CAT_REFERENCIA> CAT_REFERENCIA { get; set; }
        public DbSet<CAT_REGION> CAT_REGION { get; set; }
        public DbSet<CAT_RESPONSABLE> CAT_RESPONSABLE { get; set; }
        public DbSet<CAT_RESPUESTACORTA> CAT_RESPUESTACORTA { get; set; }
        public DbSet<CAT_RIESGOVIVIENDA> CAT_RIESGOVIVIENDA { get; set; }
        public DbSet<CAT_SECTORLABORAL> CAT_SECTORLABORAL { get; set; }
        public DbSet<CAT_SERVICIOSVIVIENDA> CAT_SERVICIOSVIVIENDA { get; set; }
        public DbSet<CAT_SEXO> CAT_SEXO { get; set; }
        public DbSet<CAT_SITUACION> CAT_SITUACION { get; set; }
        public DbSet<CAT_TEMADESTREZA> CAT_TEMADESTREZA { get; set; }
        public DbSet<CAT_TIPOASISTENCIA> CAT_TIPOASISTENCIA { get; set; }
        public DbSet<CAT_TIPOBONO> CAT_TIPOBONO { get; set; }
        public DbSet<CAT_TIPOCIELORASO> CAT_TIPOCIELORASO { get; set; }
        public DbSet<CAT_TIPOCURSO> CAT_TIPOCURSO { get; set; }
        public DbSet<CAT_TIPODISCAPACIDAD> CAT_TIPODISCAPACIDAD { get; set; }
        public DbSet<CAT_TIPOEDUCACIONBASICA> CAT_TIPOEDUCACIONBASICA { get; set; }
        public DbSet<CAT_TIPOEDUCACIONSUPERIOR> CAT_TIPOEDUCACIONSUPERIOR { get; set; }
        public DbSet<CAT_TIPOEDUCACIONTECNICA> CAT_TIPOEDUCACIONTECNICA { get; set; }
        public DbSet<CAT_TIPOHORARIO> CAT_TIPOHORARIO { get; set; }
        public DbSet<CAT_TIPOIDENTIFICACION> CAT_TIPOIDENTIFICACION { get; set; }
        public DbSet<CAT_TIPOINGRESOMONETARIO> CAT_TIPOINGRESOMONETARIO { get; set; }
        public DbSet<CAT_TIPOLUGARREUNION> CAT_TIPOLUGARREUNION { get; set; }
        public DbSet<CAT_TIPOPARED> CAT_TIPOPARED { get; set; }
        public DbSet<CAT_TIPOPISOVIVIENDA> CAT_TIPOPISOVIVIENDA { get; set; }
        public DbSet<CAT_TIPOPLANVIDA> CAT_TIPOPLANVIDA { get; set; }
        public DbSet<CAT_TIPOPOBLACION> CAT_TIPOPOBLACION { get; set; }
        public DbSet<CAT_TIPOSEGURO> CAT_TIPOSEGURO { get; set; }
        public DbSet<CAT_TIPOSPROPIEDAD> CAT_TIPOSPROPIEDAD { get; set; }
        public DbSet<CAT_TIPOTECHOVIVIENDA> CAT_TIPOTECHOVIVIENDA { get; set; }
        public DbSet<CAT_TIPOTENENCIA> CAT_TIPOTENENCIA { get; set; }
        public DbSet<CAT_TIPOVIOLENCIA> CAT_TIPOVIOLENCIA { get; set; }
        public DbSet<CAT_TIPOVIVIENDA> CAT_TIPOVIVIENDA { get; set; }
        public DbSet<CAT_TITULOEDUCATIVO> CAT_TITULOEDUCATIVO { get; set; }
        public DbSet<CAT_UTILIDADESTUDIO> CAT_UTILIDADESTUDIO { get; set; }
        public DbSet<CAT_VALORACIONAPOYO> CAT_VALORACIONAPOYO { get; set; }
        public DbSet<SEG_OPCIONSISTEMA> SEG_OPCIONSISTEMA { get; set; }
        public DbSet<SEG_PERFIL> SEG_PERFIL { get; set; }
        public DbSet<SEG_USUARIO> SEG_USUARIO { get; set; }
        public DbSet<T_ACTIVIDADECONOMICAPARTICIPANTEJEFATURA> T_ACTIVIDADECONOMICAPARTICIPANTEJEFATURA { get; set; }
        public DbSet<T_ARCHIVOGRUPO> T_ARCHIVOGRUPO { get; set; }
        public DbSet<T_ASEGURAMIENTOINTEGRANTE> T_ASEGURAMIENTOINTEGRANTE { get; set; }
        public DbSet<T_ASISTENCIA> T_ASISTENCIA { get; set; }
        public DbSet<T_BITACORA> T_BITACORA { get; set; }
        public DbSet<T_ERROR> T_ERROR { get; set; }
        public DbSet<T_EVENTOBITACORA> T_EVENTOBITACORA { get; set; }
        public DbSet<T_GRUPO> T_GRUPO { get; set; }
        public DbSet<T_HORARIOGRUPO> T_HORARIOGRUPO { get; set; }
        public DbSet<T_INTEGRANTEBENEFICIO> T_INTEGRANTEBENEFICIO { get; set; }
        public DbSet<T_INTEGRANTEGRUPOFAMILIAR> T_INTEGRANTEGRUPOFAMILIAR { get; set; }
        public DbSet<T_INTEGRANTEPENSIONAPOYO> T_INTEGRANTEPENSIONAPOYO { get; set; }
        public DbSet<T_LOCALIZACIONPARTICIPANTE> T_LOCALIZACIONPARTICIPANTE { get; set; }
        public DbSet<T_PARTICIPANTE> T_PARTICIPANTE { get; set; }
        public DbSet<T_PARTICIPANTECONDICIONESVIDA> T_PARTICIPANTECONDICIONESVIDA { get; set; }
        public DbSet<T_PARTICIPANTEEDUCACIONFORMAL> T_PARTICIPANTEEDUCACIONFORMAL { get; set; }
        public DbSet<T_PARTICIPANTEFORMACIONTECNICA> T_PARTICIPANTEFORMACIONTECNICA { get; set; }
        public DbSet<T_PARTICIPANTEHISTORIAVIDA> T_PARTICIPANTEHISTORIAVIDA { get; set; }
        public DbSet<T_PARTICIPANTEVIVIENDA> T_PARTICIPANTEVIVIENDA { get; set; }
        public DbSet<T_PLANEDUCACIONFORMAL> T_PLANEDUCACIONFORMAL { get; set; }
        public DbSet<T_PLANEDUCACIONTECNICA> T_PLANEDUCACIONTECNICA { get; set; }
        public DbSet<T_PLANEMPLEABILIDAD> T_PLANEMPLEABILIDAD { get; set; }
        public DbSet<T_PLANOTROS> T_PLANOTROS { get; set; }
        public DbSet<T_PLANPROYECTOPRODUCTIVO> T_PLANPROYECTOPRODUCTIVO { get; set; }
        public DbSet<T_PLANSALUD> T_PLANSALUD { get; set; }
        public DbSet<T_PLANVIDAVIVIENDAACTUAL> T_PLANVIDAVIVIENDAACTUAL { get; set; }
        public DbSet<T_PROGRAMAPERSONA> T_PROGRAMAPERSONA { get; set; }
        public DbSet<T_SEGUIMIENTOPLANVIDA> T_SEGUIMIENTOPLANVIDA { get; set; }
        public DbSet<T_TIPOERROR> T_TIPOERROR { get; set; }
    }
}