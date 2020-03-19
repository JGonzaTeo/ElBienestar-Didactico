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

    }
}

