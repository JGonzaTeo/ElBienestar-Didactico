using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cDatos;

using System.Data.Odbc;

namespace cLogica
{
   public class logica
    {
     sentencias sn = new sentencias();
        public OdbcDataReader ingresoproducto(string codigo_bodega, string nombre_bodega, string direccion)
        {
            return sn.Insertarbodega(codigo_bodega, nombre_bodega, direccion);
        }
        public OdbcDataReader ingresoproducto(string codigoproducto, string codigobodega, string nombreproducto, string existencias)
        {
            return sn.Insertarproducto(codigoproducto, codigobodega, nombreproducto, existencias );
        }
        public OdbcDataReader Rellenobodega()
        {
            return sn.Rellenobodegas();
        }
        public OdbcDataReader consultaproducto(string campo)
        {
            return sn.consultaproducto(campo);
        }
        public OdbcDataReader consultaubicaciones(string campos)
        {
            return sn.consultaubicacion(campos);
        }
        public OdbcDataReader deletebodega(string campo)
        {
            return sn.deletebodega(campo);
        }
        public OdbcDataReader deleteproducto(string campo)
        {
            return sn.deleteproducto(campo);
        }

        public OdbcDataReader modificarproducto(string campo)
        {
            return sn.consultaproductos(campo);
        }
        public OdbcDataReader modificarbodega(string campo)
        {
            return sn.consultabodega(campo);
        }

        public OdbcDataReader cambiobodega(string codigobodega, string nombrebodega, string direccion)
        {
            return sn.cambiosbodega(codigobodega, nombrebodega, direccion);
        }

        public OdbcDataReader cambioproducto(string codigoproducto, string codigobodega, string nombreproducto, string existencias)
        {
            return sn.cambiosproducto(codigoproducto, codigobodega, nombreproducto, existencias);
        }
    }
}
