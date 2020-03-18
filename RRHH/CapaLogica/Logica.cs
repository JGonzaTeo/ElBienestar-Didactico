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
        public OdbcDataReader TestTabla(string tabla)
        {
            return sn.ProbarTabla(tabla);
        }

       
    }
}
