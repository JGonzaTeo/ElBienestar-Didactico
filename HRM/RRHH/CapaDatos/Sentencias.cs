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

        public OdbcDataReader consultaJornada(string campo)
        {
            string error = "";
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
    }
}
