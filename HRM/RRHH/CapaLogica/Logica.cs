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


    }
}

