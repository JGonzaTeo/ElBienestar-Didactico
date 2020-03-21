using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader Insertarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + sCodigo + ", '" + sNombre + "' ,'" + sTipoconcepto + "','" + ssaldo + "','" + stipoaccion + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set nombreconcepto='" + sNombre + "',tipo_concepto='" + sTipoconcepto + "',saldo='" + ssaldo + "',tipo_accion='" + stipoaccion + "',estado='" + sestado + "' where pkcodigoconcepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------DELETE-------------------------------------------------------//
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set estado='0' where pkcodigoconcepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        public OdbcDataReader Insertarnomina(string sCodigo, string sTiponomina, string sFechainicio, string sfechafin, string sCodigoemp, string sobservaciones, string ssaldototal)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into nomina_encabezado values(" + sCodigo + ", '" + sTiponomina + "' ,'" + sFechainicio + "','" + sfechafin + "','" + sCodigoemp + "','" + sobservaciones + "','" + ssaldototal + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //Obtener Siguiente
        public string obtenerfinal(string tabla, string campo)// metodo  que obtinene el contenio de una tabla
        {


            String camporesultante = "";
            try
            {

                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;

        }

        //---------------------------------------------INSERT SOLICITUD NUEVA ENCABEZADO Y DETALLE-------------------------------------------------------//
        public OdbcDataReader InsertarSolicitudEmpleadoN(string scampo, string creador, string tipo, string fecha, string p2, string s2, string b2, string es2, string g2, string c2, string extras)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tbl_solicitud_empleado_encabezado values("+ scampo + ',' + creador + ',' + tipo + ',' + "'"+ fecha +"' , 1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                string consulta2 = "insert into tbl_solicitud_empleado_detalle values(" + scampo + ',' + p2 + ',' + s2 + ',' + b2 + ',' + es2 + ',' + g2 + ',' + c2 + ',' + "'" + extras + "',1);";
                comm = new OdbcCommand(consulta2, cn.conexionbd());
                OdbcDataReader mostrar2 = comm.ExecuteReader();
                Console.WriteLine("Devuelve "+mostrar);
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------INSERT PERFIL-------------------------------------------------------//
        public OdbcDataReader InsertarPerfil(string scampo, string puesto, string p2, string s2, string b2, string es2, string g2, string c2, string extras)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into perfil_encabezado values(" + scampo +  ',' + puesto  +",1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                string consulta2 = "insert into perfil_detalle values(" + scampo + ',' + p2 + ',' + s2 + ',' + b2 + ',' + es2 + ',' + g2 + ',' + c2 + ',' + "'" + extras + "',1);";
                comm = new OdbcCommand(consulta2, cn.conexionbd());
                OdbcDataReader mostrar2 = comm.ExecuteReader();
                Console.WriteLine("Devuelve " + mostrar);
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarPerfil(string scampo, string puesto, string p2, string s2, string b2, string es2, string g2, string c2, string extras)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE perfil_encabezado set fkcodigopuesto='" + puesto  + "' where pkcodperfil='" + scampo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                string consulta2 = "UPDATE perfil_detalle set fkcodperfil='" + scampo + "', primaria='" + p2 + "', secundaria='" + s2 + "', bachillerato='" + b2 + "', estudiante_U='" + es2 + "', graduado_U='" + g2 +"', curso_extra='" + c2 + "', descripcion_curso='" + extras  + "' where fkcodperfil='" + scampo + "';";
                comm = new OdbcCommand(consulta2, cn.conexionbd());
                OdbcDataReader mostrar2 = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------DELETE PERFIL-------------------------------------------------------//
        public OdbcDataReader eliminarPerfil(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE perfil_encabezado set estado='0' where pkcodperfil='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                string consulta2 = "UPDATE perfil_detalle set estado='0' where fkcodperfil='" + sCodigo + "';";
                comm = new OdbcCommand(consulta2, cn.conexionbd());
                OdbcDataReader mostrar2 = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//


        /*CONSULTA PRESELECCION*/
        public OdbcDataReader ConsultaSeleccionFiltro(string id)
        {
            try
            {
                cn.conexionbd();
                string consulta = "select pkidCurriculum, nombre, apellido, numero, direccion, correo_electronico from tbl_curriculums where fksolicitudempleado =" + id + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader ConsultaSeleccionComparacion(string id)
        {
            try
            {
                cn.conexionbd();
                string consulta = " select primaria, secundaria, bachillerato, estudiante_universitario, graduadoU, cursoExtra, sueldo_Base from tbl_solicitud_empleado_detalle where pksolicitudempleado = " + id + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader ConsultaSeleccionComparacionAceptados(string id)
        {
            try
            {
                cn.conexionbd();
                string consulta = " select  primaria, secundaria, bachillerato, estudiante_universitario, graduadoU, cursoExtra, sueldoesperado, pkidCurriculum, Nombre, apellido from tbl_curriculums where fksolicitudempleado =" + id + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        /*FIN CONSULTA PRESELECCION*/

        /*INSERTAR BANCO*/
        public OdbcDataReader InsertarBanco(string codCurri)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tbl_bancotalento values (0," + codCurri + ", 1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        //---------------------------------------------------------------------------------------------------INSERTMNTEMPLEADO-----------------//
        public OdbcDataReader InsertarEmp(string Pnombre, string Snombre, string Papellido, string Sapellido, string telefono, string celular, string email, string direccion, string Eestado)
        {
            try
            {

                cn.conexionbd();
                string consulta = "insert into empleado values(" + Pnombre + ", '" + Snombre + "' ,'" + Papellido + "','" + Sapellido + "','" + telefono + "','" + celular + "','" + email + "','" + direccion + "','" + Eestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------//

        //---------------------------------------------------------------------------------------------------UPDATE EMPLEADO------------------//
        public OdbcDataReader UpdateEmp(string Cod, string Pnombre, string Snombre, string Papellido, string Sapellido, string telefono, string celular, string email, string direccion, string Eestado)
        {
            try
            {

                cn.conexionbd();
                string consulta = "UPDATE empleado set primernombre='" + Pnombre + "',segundonombre='" + Snombre + "',primerapellido='" + Papellido + "',segundoapellido='" + Sapellido + "',telefono='" + telefono + "',email ='" + email + "',direccion='" + direccion + "',estado='" + Eestado + "' where pkcodigoempleado='" + Cod + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------//

        //-------------------------------------------------------------------------------------ELIMINAR EMPLEADO---------------------------//

        public OdbcDataReader EliminarEmp(string Eestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set estado='0' where pkcodigoempleado='" + Eestado + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------//

        //-------------------------------------------------------------------------------------CONSULTAAAAA EMPLEADO ---------------------//
        public OdbcDataReader consultaempleado(string codemp)
        {

            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM empleado WHERE pkcodigoempleado = " + codemp + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }

        //---------------------------------------------------------------------------------------------------INSERTAR MEDIO DE COMUNICACION---//
        public OdbcDataReader InsertarMC(string Nombre, string Direccion, string Telefono, string Eestado)
        {
            try
            {

                cn.conexionbd();
                string consulta = "insert into mediodecomunicacion values(" + Nombre + ", '" + Direccion + "' ,'" + Telefono + "','" + Eestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------//

        //--------------------------------------------------------------------------------------------------- UPDATE MEDIO DE COMUNICACION----//
        public OdbcDataReader UpdateMC(string ID, string Nombre, string Direccion, string Telefono, string Eestado)
        {
            try
            {

                cn.conexionbd();
                string consulta = "UPDATE mediodecomunicacion set Nombre='" + Nombre + "',Direccion='" + Direccion + "'Telefono='" + Telefono + "',Estado ='" + Eestado + "' where idMediodeComunicacion ='" + ID + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------- ELIMINAR MEDIO DE COMUNICACION ----------------------------//

        public OdbcDataReader EliminarMC(string Eestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE mediodecomunicacion set estado='0' where idMediodeComunicacion='" + Eestado + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------//

        //-------------------------------------------------------------------------------------CONSULTAAAAA MC ------------------------------------------//
        public OdbcDataReader consultaMC(string code)
        {

            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM mediodecomunicacion WHERE pkmediodecomunicacion = " + code + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------------------------------------------INSERTAR TIPO DE CONTRATACION -------------------------------------------------------//
        public OdbcDataReader InsertarTipoC(string Contrato, string Mes, string Proyecto, string Eestado)
        {
            try
            {

                cn.conexionbd();
                string consulta = "insert into tipocontratacion values(" + Contrato + ", '" + Mes + "' ,'" + Proyecto + "','" + Eestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //--------------------------------------------------------------------------------------------------- UPDATE TIPO DE CONTRATACION-------------------------------------------------------//
        public OdbcDataReader UpdateTipoC(string Cod, string Contrato, string Mes, string Proyecto, string Eestado)
        {
            try
            {

                cn.conexionbd();
                string consulta = "UPDATE tipocontratacion set PorContrato='" + Contrato + "',PorMes='" + Mes + "'PorProyecto='" + Proyecto + "',Estado ='" + Eestado + "' where pkcodigocontratacion ='" + Cod + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------- ELIMINAR TIPO DE CONTRATACION ------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader EliminarTipoC(string Eestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipocontratacion set estado='0' where idMediodeComunicacion='" + Eestado + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //-------------------------------------------------------------------------------------CONSULTAAAAA EMPLEADO -------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaCotratacion(string codemp)
        {

            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM  tipocontratacion WHERE pkcodigocontratacion = " + codemp + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }


        /********************************CONSULTA DE SOLICITUD EMPLEADO*********************************************************************/
        public OdbcDataReader ConsultaLogicaSolicitudE(string COD)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = "SELECT * FROM tbl_solicitud_empleado_encabezado WHERE pksolicitudempleado="+ COD+";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        /***************CONSULTA BUSQUEDA INTERNA****************************************************/
        public OdbcDataReader ConsultaLogicaBusquedaInterna(string id)
        {
            try
            {
                cn.conexionbd();
                string consulta = " select * from tbl_solicitud_empleado_detalle where pksolicitudempleado = " + id + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        /***************CONSULTA BUSQUEDA INTERNA****************************************************/
        public OdbcDataReader ConsultaPerfilDetalle()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM perfil_detalle;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        /***************CONSULTA PERFIL Y PUESTO****************************************************/
        public OdbcDataReader ConsultaEmpleadoyPuesto(string COD)
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select e.pkcodigoempleado, e.fkcodigojornada, e.primernombre,e.primerapellido, p.pkcodigopuesto from empleado e inner join puesto p on e.pkcodigoempleado = p.fkcodigoempleado inner join perfil_encabezado l on p.pkcodigopuesto = l.fkcodigopuesto where l.pkcodperfil ='" + COD + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        /***************************INSERTAR BANCO****************************************************/
        public OdbcDataReader InsertarAptos(string solicitud, string perfil)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into candidatos_internos values (0," + solicitud + "," + perfil + ", 1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------INSERT CURRICULUM-------------------------------------------------------//
        public OdbcDataReader InsertarCurriculum(string scampo, string nombre, string apellido, string numero, string direccion, string correo, string p2, string s2, string b2, string es2, string g2, string c2, string extras, string experiencia, string sueldo, string solicitud)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tbl_curriculums values(" + scampo + ',' + nombre + ',' + apellido + ',' + numero + ',' + direccion + ',' + correo + ',' + p2 + ',' + s2 + ',' + b2 + ',' + es2 + ',' + g2 + ',' + c2 + ',' + extras + ',' + experiencia + ',' + sueldo + ',' + solicitud + ",1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarCurriculum(string scampo, string nombre, string apellido, string numero, string direccion, string correo, string p2, string s2, string b2, string es2, string g2, string c2, string extras, string experiencia, string sueldo, string solicitud)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tbl_curriculums set ='" + scampo + "', Nombre='" + nombre + "', Apellido='" + apellido + "', Numero='" + numero + "', Direccion='" + direccion + "', Correo_Electronico='" + correo + "', primaria='" + p2 + "', secundaria='" + s2 + "', bachillerato='" + b2 + "', estudiante_U='" + es2 + "', graduado_U='" + g2 + "', curso_extra='" + c2 + "', descripcion_curso='" + extras + "', Experiencia_Previa='" + experiencia + "', SueldoEsperado='" + sueldo + "', fksolicitudempleado='" + solicitud + "' where fkcodperfil='" + scampo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------DELETE CURRICULUM-------------------------------------------------------//
        public OdbcDataReader eliminarCurriculum(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tbl_curriculums set estado='0' where pkidCurriculum='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------------------DESEMPEÑO-------------------------------------------------------------------------//
        public OdbcDataReader InsertarKpi(string fechaEvaluacion, string totalEmpleado, string desempeño)
        {
            try
            {
                cn.conexionbd();
                string consulta = "INSERT INTO tbl_kpi values (0," + fechaEvaluacion + totalEmpleado + desempeño + " ) ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader InsertarCategoria(string nombreCat)
        {
            try
            {
                cn.conexionbd();
                string consulta = "INSERT INTO tbl_categoria values (0," + nombreCat + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }  
        }

        public OdbcDataReader InsertarMeta(string nombreMeta, string tipoMeta, string descrip, string comple, string fechaMeta)
        {
            try
            {
                cn.conexionbd();
                string consulta = "INSERT INTO metas values (0," + nombreMeta + tipoMeta + descrip + comple + fechaMeta + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- BUSCAR EMPLEADO ------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader BuscarEmpleadoS(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "select primernombre,primerapellido from empleado where pkcodigoempleado = " + sCodigo + " and estado = 1; ";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------- INGRESO CONTROL ASISTENCIA ------------------------------------------------------------------------------------------------------------------------------------
        public OdbcDataReader InsertarControlAsistencia(string sCodigoEmpleado, string sNombre, string sApellido, string sFechaIngreso, string sHoraIngreso)
        {
            try
            {

                string consulta = "INSERT INTO asistencia(fkcodigoempleado, fechaentrada, horaentrada) values(" + sCodigoEmpleado + ", '" + sFechaIngreso + "', '" + sHoraIngreso + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- INGRESO REUNION ------------------------------------------------------------------------------------------------------------------------------------
        public OdbcDataReader InsertarReunion(string sCodigoEmpleado, string sNombre, string sDescripcion, string sFechaInicio, string sFechaFinal, string sHoraInicio, string sHoraFinal, string sCantidad)
        {
            try
            {
                int iDisponible = 1;
                string consulta = "INSERT INTO reuniones(fkcodigoempleado, nombrereunion, descripcion, fechainicio, fechafinal, horainicio, horafinal, cantidadempleados, estado)  values(" + sCodigoEmpleado + ", '" + sNombre + "', '" + sDescripcion + "', '" + sFechaInicio + "', '" + sFechaFinal + "', '" + sHoraInicio + "', '" + sHoraFinal + "', '" + sCantidad + "', '" + iDisponible + "');";

                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------- BUSCAR EMPLEADO REUNION ------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader BuscarEmpleadoReunion(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "select primernombre from empleado where pkcodigoempleado = " + sCodigo + " and estado = 1; ";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- BUSCAR REUNION ------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader BuscarReunion(string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "select descripcion,fechainicio,fechafinal,horainicio,horafinal,cantidadempleados from reuniones where nombrereunion = '" + sNombre + "' and estado = 1; ";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- UPDATE REUNION ------------------------------------------------------------------------------------------------------------------------------------
        public OdbcDataReader UpdateReunion(string sNombre, string sDescripcion, string sFechaInicio, string sFechaFinal, string sHoraInicio, string sHoraFinal, string sCantidad)
        {
            try
            {
                cn.conexionbd();
                int iDisponible = 1;
                string consulta = "UPDATE reuniones set descripcion='" + sDescripcion + "',fechainicio='" + sFechaInicio + "',fechafinal='" + sFechaFinal + "',horainicio ='" + sHoraInicio + "',horafinal ='" + sHoraFinal + "',cantidadempleados ='" + sCantidad + "' where nombrereunion ='" + sNombre + "' AND estado ='" + iDisponible + "'; ";

                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- DELETE REUNION ------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader DeleteReunion(string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE reuniones set estado='0' where nombrereunion ='" + sNombre + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- INSERTAR DESPIDO ------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader InsertarDespido(string sCodigoEmpleado, string sRazonDespido, string sDescripcion, string sFecha)
        {
            try
            {
                cn.conexionbd();
                //InsertarDespido
                string consulta = "INSERT INTO despidoempleado(fkcodigoempleado,razondespido,descripciondespido,fechadespido)  values(" + sCodigoEmpleado + ", '" + sRazonDespido + "', '" + sDescripcion + "', '" + sFecha + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();

                //Update Eliminar Empleado
                string consulta2 = "UPDATE empleado set estado='0' where pkcodigoempleado ='" + sCodigoEmpleado + "';";
                comm = new OdbcCommand(consulta2, cn.conexionbd());
                OdbcDataReader mostrar2 = comm.ExecuteReader();

                return mostrar;
            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------- INSERTAR SANSION ------------------------------------------------------------------------------------------------------------------------------------
        public OdbcDataReader InsertarSansion(string sCodigoEmpleado, string sRazonSansion, string sDescripcion, string sFechaInicio, string sFechaFinal)
        {
            try
            {
                int iDisponible = 1;
                string consulta = "INSERT INTO sancionempleado(fkcodigoempleado, nombre,descipcion, fechainicio, fechafinal, estado)  values(" + sCodigoEmpleado + ", '" + sRazonSansion + "', '" + sDescripcion + "', '" + sFechaInicio + "', '" + sFechaFinal + "', '" + iDisponible + "');";

                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------- BUSCAR SANSION ------------------------------------------------------------------------------------------------------------------------------------
        public OdbcDataReader BuscarSansion(string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "select fkcodigoempleado,descipcion,fechainicio,fechafinal from sancionempleado where nombre = '" + sNombre + "' and estado = 1; ";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //------------------------------------------------------------------------------------- ELIMINAR SANSION ------------------------------------------------------------------------------------------------------------------------------------
        public OdbcDataReader DeleteSansion(string sNombre)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sancionempleado set estado='0' where nombre ='" + sNombre + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //JORNADA
        //------------------------------------------------------------------------------------------------------CONSULTA-------------------------------------------------------//
        public OdbcDataReader consultaJornada(string campo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM jornada WHERE pkcodigojornada = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader insertarJornada(string codigoJornada, string nombreJornada, string horasJornada, string estadoJornada)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into jornada values(" + codigoJornada + ", '" + nombreJornada + "' ,'" + horasJornada + "','" + estadoJornada + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarJornada(string codigoJornada, string nombreJornada, string horasJornada, string estadoJornada)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE jornada set nombrejornada='" + nombreJornada + "',horasjornada='" + horasJornada + "',estado='" + estadoJornada + "' where pkcodigojornada='" + codigoJornada + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------DELETE-------------------------------------------------------//
        public OdbcDataReader eliminarJornada(string codigoJornada)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE jornada set estado='0' where pkcodigojornada='" + codigoJornada + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //--------------------------------------------UPDATE DEPARTAMENTOS-----------------------------------------------------//
        public OdbcDataReader modificarDepartamento(string sCodigo, string sNombre, string sdescripcion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamentos set nombredepto='" + sNombre + "', descripciondepto='" + sdescripcion + "' where pkcodigodepto=" + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //-----------------------------------------------------INSERTS DEPARTAMENTO-------------------------------------------------------//
        public OdbcDataReader InsertarDepartamento(string sCodigo, string sNombre, string sdescripcion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into departamentos values(" + sCodigo + ", '" + sNombre + "' ,'" + sdescripcion + "',1);";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //-------------------------------------------------DELETE DEPARTAMENTO-------------------------------------------------------//
        public OdbcDataReader eliminarDepartamento(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamentos set estado='0' where pkcodigodepto ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

    }
}
