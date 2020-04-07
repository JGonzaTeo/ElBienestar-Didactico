using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace cDatos
{
   public class sentencias
    {
        conecxion cn = new conecxion();
        OdbcCommand comm;
        public OdbcDataReader Insertarbodega(string codigobodega, string nombrebodega, string direccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into bdbodega.tbl_bodega (codigo_bodega, nombre_bodega ,direccion) values(" + codigobodega + ", '" + nombrebodega + "' ,'" + direccion + "');";
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
        public OdbcDataReader Insertarproducto(string codigoproducto, string codigobodega, string nombreproducto, string existencias)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into bdbodega.tbl_productos (codigo_producto, codigo_bodega , nombre_producto, existencias) values(" + codigoproducto + ", '" + codigobodega + "' ,'" + nombreproducto  + "','" + existencias  + "');";
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
        public OdbcDataReader consultaproducto(string campo)
        {
            try
            {
              
                cn.conexionbd();
                string consulta = "SELECT  codigo_bodega FROM bdbodega.tbl_productos WHERE codigo_producto = " + campo + " ;";
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

        public OdbcDataReader deleteproducto (string campo)
        {
            try
            {

                cn.conexionbd();
                string consulta = "DELETE  FROM bdbodega.tbl_productos WHERE codigo_producto =  " + campo + " ;";
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

        public OdbcDataReader consultaproductos(string campo)
        {
            try
            {

                cn.conexionbd();
                string consulta = "select * FROM bdbodega.tbl_productos WHERE codigo_producto = " + campo + " ;";
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

        public OdbcDataReader consultabodega(string campo)
        {
            try
            {

                cn.conexionbd();
                string consulta = "select * FROM bdbodega.tbl_bodega WHERE codigo_bodega = " + campo + " ;";
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

        public OdbcDataReader deletebodega(string campo)
        {
            try
            {

                cn.conexionbd();
                string consulta = "DELETE  FROM bdbodega.tbl_bodega WHERE codigo_bodega =  " + campo + " ;";
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

        public OdbcDataReader consultaubicacion(string campos)
        {
            try
            {
             
                cn.conexionbd();
                string consulta = "SELECT nombre_bodega FROM bdbodega.tbl_bodega WHERE codigo_bodega =  " + campos + " ;";
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
        public OdbcDataReader Rellenobodegas()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM bdbodega.tbl_bodega;";
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
        public OdbcDataReader cambiosproducto(string codigoproducto, string codigobodega, string nombreproducto, string existencias)
        {
            try
            {
                cn.conexionbd();
                string consulta = "update bdbodega.tbl_productos set  codigo_bodega= '" + codigobodega + "', nombre_producto='" + nombreproducto + "', existencias='" + existencias + "' WHERE codigo_producto = '" + codigoproducto + "';";
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
        public OdbcDataReader cambiosbodega( string codigobodega, string nombrebodega, string direccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "update bdbodega.tbl_bodega set  nombre_bodega='" + nombrebodega + "', direccion='" + direccion + "' WHERE codigo_bodega = '" + codigobodega + "';";
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
