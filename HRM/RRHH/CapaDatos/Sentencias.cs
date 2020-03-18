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
                string consulta = "insert into tbl_solicitud_empleado_encabezado values("+ scampo + ',' + creador + ',' + tipo + ',' + "'"+ fecha +"');";
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

    }
}
