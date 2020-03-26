using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Odbc;
namespace CapaLogica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
        public OdbcDataReader verificacionJornada(string numero)
        {
            return sn.consultaJornada(numero);
        }
        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader Insertarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            return sn.Insertarconcepto(sCodigo, sNombre, sTipoconcepto, ssaldo, stipoaccion, sestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarConcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            return sn.modificarconcepto(sCodigo, sNombre, sTipoconcepto, ssaldo, stipoaccion, sestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            return sn.eliminarconcepto(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public OdbcDataReader Insertarnomina(string sCodigo, string sTiponomina, string sFechainicio, string sfechafin, string sCodigoemp, string sobservaciones, string ssaldototal)
        {
            return sn.Insertarnomina(sCodigo, sTiponomina, sFechainicio, sfechafin, sCodigoemp, sobservaciones, ssaldototal);          
        }
        //Obtener siguiente registro
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }
        //---------------------------------------------------------------INSERT NUEVA SOLICITUD ENCABEZADO Y DETALLE-------------------------------------------------------//
        public OdbcDataReader InsertarSolicitudEmpleado(string scampo, string creador, string tipo, string fecha, string  p2, string s2, string  b2, string  es2, string  g2, string  c2, string  extras)
        {
            return sn.InsertarSolicitudEmpleadoN( scampo,  creador,  tipo, fecha, p2, s2, b2, es2, g2, c2, extras);
        }
        //---------------------------------------------------------------INSERT NUEVA PERFIL-------------------------------------------------------//
        public OdbcDataReader InsertarPerfil(string scampo, string puesto, string p2, string s2, string b2, string es2, string g2, string c2, string extras)
        {
            return sn.InsertarPerfil(scampo, puesto, p2, s2, b2, es2, g2, c2, extras);
        }
        //-----------------------------------------------UPDATE PERFILES-------------------------------------------------------//
        public OdbcDataReader modificarPerfil(string scampo, string puesto, string p2, string s2, string b2, string es2, string g2, string c2, string extras)
        {
            return sn.modificarPerfil(scampo, puesto, p2, s2, b2, es2, g2, c2, extras);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------ELIMINAR PERFIL-------------------------------------------------------//
        public OdbcDataReader eliminarPerfil(string sCodigo)
        {
            return sn.eliminarPerfil(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /*PRESELECCION*/
        public OdbcDataReader ConsultaLogicaPreseleccionFiltro(string id)
        {
            return sn.ConsultaSeleccionFiltro(id);
        }

        public OdbcDataReader ConsultaLogicaPreseleccionComparacion(string id)
        {
            return sn.ConsultaSeleccionComparacion(id);
        }

        public OdbcDataReader ConsultaSeleccionComparacionAceptados(string id)
        {
            return sn.ConsultaSeleccionComparacionAceptados(id);
        }
        /*FIN DE PRESELECCION*/
        /*INSERTAR BANCO*/
        public OdbcDataReader InsertarBanco(string codCurri)
        {
            return sn.InsertarBanco(codCurri);
        }
        /*FIN DE INSERTAR BANCO*/
        //------------------------------------------------------------------------------------------------------INSERTEMPLEADO--------//
        public OdbcDataReader Insertarempleado(string Pnombre, string Snombre, string Papellido, string Sapellido, string telefono, string celular, string email, string direccion, string Eestado)
        {
            return sn.InsertarEmp(Pnombre, Snombre, Papellido, Sapellido, telefono, celular, email, direccion, Eestado);
        }
        //---------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE EMPLEADO------//
        public OdbcDataReader ModificarEmpleado(string Cod, string Pnombre, string Snombre, string Papellido, string Sapellido, string telefono, string celular, string email, string direccion, string Eestado)
        {
            return sn.UpdateEmp(Cod, Pnombre, Snombre, Papellido, Sapellido, telefono, celular, email, direccion, Eestado);
        }
        //--------------------------------------------------------------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------ELIMINAR EMPLEADO----------//
        public OdbcDataReader eliminarEmpleado(string Eestado)
        {
            return sn.EliminarEmp(Eestado);
        }
        //-------------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------CONSULTA EMPLEADO--------------------------//
        public OdbcDataReader consultaempleado(string codigoemp)
        {
            return sn.consultaJornada(codigoemp);
        }
        //------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR MC------//
        public OdbcDataReader InsertarMC(string Nombre, string Direccion, string Telefono, string Eestado)
        {
            return sn.InsertarMC(Nombre, Direccion, Telefono, Eestado);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
       //------------------------------------------------------------------------------------------------------UPDATE MC-------//
        public OdbcDataReader ModificarMC(string ID, string Nombre, string Direccion, string Telefono, string Eestado)
        {
            return sn.UpdateMC(ID, Nombre, Direccion, Telefono, Eestado);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------ELIMINAR MC ----//
        public OdbcDataReader eliminarMC(string Eestado)
        {
            return sn.EliminarMC(Eestado);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaMEDIO(string codigomedio)
        {
            return sn.consultaJornada(codigomedio);
        }
        //------------------------------------------------------------------------------INSERTAR TIPO CONTRATACION ---------]---//
        public OdbcDataReader InsertarTC(string Contrato, string Mes, string Proyecto, string Eestado)
        {
            return sn.InsertarMC(Contrato, Mes, Proyecto, Eestado);
        }
        //----------------------------------------------------------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------UPDATE TIPO CONTRATACION------//
        public OdbcDataReader ModificarTC(string Cod, string Contrato, string Mes, string Proyecto, string Eestado)
        {
            return sn.UpdateMC(Cod, Contrato, Mes, Proyecto, Eestado);
        }
        //---------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------ELIMINAR TIPO CONTRATACION -------------------------------------------------------//
        public OdbcDataReader eliminarTC(string Eestado)
        {
            return sn.EliminarMC(Eestado);
        }
        //---------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------------------------CONSULTA CONTRATACION-------------------------------------------------------------------------------------------------//
        public OdbcDataReader consultacontratacion(string codigocontr)
        {
            return sn.consultaJornada(codigocontr);
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /*************************************CONSULTA DE SOLICITUD EMPLEADO*/
        public OdbcDataReader ConsultaLogicaSolicitudE(string COD)
        {
            return sn.ConsultaLogicaSolicitudE(COD);
        }
        /***************************CCONSULTA INTERNA DE SOLICITUD*****************************************/
        public OdbcDataReader ConsultaLogicaBusquedaInterna(string id)
        {
            return sn.ConsultaLogicaBusquedaInterna(id);
        }
        /***************************CONSULTA INTERNAD DE PERFIL*****************************************/
        public OdbcDataReader ConsultaPerfilDetalle()
        {
            return sn.ConsultaPerfilDetalle();
        }
        /***************************CONSULTA PERFIL Y PUESTO*****************************************/
        public OdbcDataReader ConsultaEmpleadoyPuesto(string COD)
        {
            return sn.ConsultaEmpleadoyPuesto(COD);
        }
        /******************************IINSERTAR APTO*************************************************/
        public OdbcDataReader InsertarAptos(string solicitud, string perfil)
        {
            return sn.InsertarAptos(solicitud, perfil);
        }
        //---------------------------------------------------------------INSERT NUEVO CURRICULUM-------------------------------------------------------//
        public OdbcDataReader InsertarCurriculum(string scampo, string nombre, string apellido, string numero, string direccion, string correo, string p2, string s2, string b2, string es2, string g2, string c2, string extras, string experiencia, string sueldo, string solicitud)
        {
            return sn.InsertarCurriculum(scampo, nombre, apellido, numero, direccion, correo, p2, s2, b2, es2, g2, c2, extras, experiencia, sueldo, solicitud);
        }
        //-----------------------------------------------UPDATE PERFILES-------------------------------------------------------//
        public OdbcDataReader modificarCurriculum(string scampo, string nombre, string apellido, string numero, string direccion, string correo, string p2, string s2, string b2, string es2, string g2, string c2, string extras, string experiencia, string sueldo, string solicitud)
        {
            return sn.modificarCurriculum(scampo, nombre, apellido, numero, direccion, correo, p2, s2, b2, es2, g2, c2, extras, experiencia, sueldo, solicitud);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------ELIMINAR PERFIL-------------------------------------------------------//
        public OdbcDataReader eliminarCurriculum(string sCodigo)
        {
            return sn.eliminarCurriculum(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //---------------------------------------------------------------------------DESEMPEÑO-------------------------------------------------------------------------//
        //--------------------------------------------------------INSERTAR KPI-------------------------------------------------------//
        public OdbcDataReader InsertarKpi(string fechaEvaluacion, string desempeño)
        {
            return sn.InsertarKpi(fechaEvaluacion, desempeño);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------INSERTAR CATEGORIA-------------------------------------------------------//
        public OdbcDataReader InsertarCategoria(string nombreCat)
        {
            return sn.InsertarCategoria(nombreCat);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------INSERTAR META-------------------------------------------------------//
        public OdbcDataReader InsertarMeta(string nombreMeta, string tipoMeta, string descrip, string comple, string fechaMeta, string pun)
        {
            return sn.InsertarMeta(nombreMeta, tipoMeta, descrip, comple, fechaMeta, pun);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------INSERTAR TOTAL KPI-------------------------------------------------------//
        public OdbcDataReader InsertarKpiTotal(string totalKpi)
        {
            return sn.InsertarKpiTotal(totalKpi);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //pppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------BuscarEmpleado---------------------------------------------
        public OdbcDataReader BuscarEmpleado(string sCodigo)
        {
            return sn.BuscarEmpleadoS(sCodigo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------Insertar Control Asistencia----------------------------------------------------------------//
        public OdbcDataReader InsertaControlAsistencia(string sCodigoEmpleado, string sNombre, string sApellido, string sFechaIngreso, string sFechaSalida, string sHoraIngreso, string sHoraSalida, float fHorasTotales)
        {
            return sn.InsertarControlAsistencia(sCodigoEmpleado, sNombre, sApellido, sFechaIngreso,sFechaSalida, sHoraIngreso, sHoraSalida, fHorasTotales);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------Insertar Reunion----------------------------------------------------------------//
        public OdbcDataReader InsertaReunion(string sCodigoEmpleado, string sNombre, string sDescripcion, string sFechaInicio, string sFechaFinal, string sHoraInicio, string sHoraFinal, string sCantidad)
        {
            return sn.InsertarReunion(sCodigoEmpleado, sNombre, sDescripcion, sFechaInicio, sFechaFinal, sHoraInicio, sHoraFinal, sCantidad);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------BuscarEmpleadoReunion---------------------------------------------
        public OdbcDataReader BuscarEmpleadoReunion(string sCodigo)
        {
            return sn.BuscarEmpleadoS(sCodigo);
        }
        //------------------------------------------------------------------------------------------------------BuscarReunion---------------------------------------------
        public OdbcDataReader BuscarReunion(string sNombre)
        {
            return sn.BuscarReunion(sNombre);
        }
        //------------------------------------------------------------------------------------------------------ActualizarReunion---------------------------------------------
        public OdbcDataReader UpdateReunion(string sNombre, string sDescripcion, string sFechaInicio, string sFechaFinal, string sHoraInicio, string sHoraFinal, string sCantidad)
        {
            return sn.UpdateReunion(sNombre, sDescripcion, sFechaInicio, sFechaFinal, sHoraInicio, sHoraFinal, sCantidad);
        }
        //------------------------------------------------------------------------------------------------------ELIMINAR Reunion-------------------------------------------------------//
        public OdbcDataReader DeleteReunion(string sNombre)
        {
            return sn.DeleteReunion(sNombre);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR DESPIDO ---------------------------------------------
        public OdbcDataReader InsertaDespido(string sCodigoEmpleado, string sRazonDespido, string sDescripcion, string sFecha)
        {
            return sn.InsertarDespido(sCodigoEmpleado, sRazonDespido, sDescripcion, sFecha);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTAR SANSION ---------------------------------------------
        public OdbcDataReader InsertarSansion(string sCodigoEmpleado, string sRazonSansion, string sDescripcion, string sFechaInicio, string sFechaFinal)
        {
            return sn.InsertarSansion(sCodigoEmpleado, sRazonSansion, sDescripcion, sFechaInicio, sFechaFinal);
        }
        //------------------------------------------------------------------------------------------------------BUSCAR SANSION ---------------------------------------------
        public OdbcDataReader BuscarSansion(string sNombre)
        {
            return sn.BuscarSansion(sNombre);
        }
        //------------------------------------------------------------------------------------------------------ELIMINAR SANSION ---------------------------------------------
        public OdbcDataReader DeleteSansion(string sNombre)
        {
            return sn.DeleteSansion(sNombre);
        }
        //---------------------------------------------------------------------------JORNADA-------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader insertarJornada(string codigoJornada, string nombreJornada, string horasJornada, string estadoJornada)
        {
            return sn.insertarJornada(codigoJornada, nombreJornada,horasJornada,estadoJornada);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarJornada(string codigoJornada, string nombreJornada, string horasJornada, string estadoJornada)
        {
            return sn.modificarJornada(codigoJornada,nombreJornada,horasJornada,estadoJornada);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarJornada(string codigoJornada)
        {
            return sn.eliminarJornada(codigoJornada);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /********************MODIFICAR DEPARTAMENTO**************************************************************************/
        public OdbcDataReader modificarDepartamento(string sCodigo, string sNombre, string sdescripcion)
        {
            return sn.modificarDepartamento(sCodigo, sNombre, sdescripcion);
        }
        //----------------------------INSERTS DEPARTAMENTO-------------------------------------------------------//
        public OdbcDataReader InsertarDepartamento(string sCodigo, string sNombre, string sDescripcion)
        {
            return sn.InsertarDepartamento(sCodigo, sNombre, sDescripcion);
        }
        //------------------------------------ELIMINAR DEPARTAMENTO------------------------------------------------------//
        public OdbcDataReader eliminarDepartamento(string sCodigo)
        {
            return sn.eliminarDepartamento(sCodigo);
        }

        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn.insertarbitacora( sCodigo ,sip,  Smac,  susuario,  sdepartamento,  sfechahora,  saccion,  sformulario);
        }
        public OdbcDataReader buscarempleadocontable()
        {
            return sn.Consultaempleadonominal();
        }

        public OdbcDataReader insertarempleadocont(string scodempleado, string scodconcepto)
        {
            return sn.insertarempleadoconable(scodempleado, scodconcepto);
        }
  
        public OdbcDataReader consultarnomina()
        {
            return sn.Consultanomina();
        }

        public OdbcDataReader ConsultaTotalKpi(string id)
        {
            return sn.ConsultaTotalKpi(id);
        }
    }
}

