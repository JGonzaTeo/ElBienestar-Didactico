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
        public OdbcDataReader ProbarTabla(string campo)
        {
            string error = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_wsrenap WHERE CUI = "+ campo +" ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                string nom1 = reader.GetString(0);
                Console.WriteLine(nom1);
                reader.Close();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }
            
        }

        


    }
}
