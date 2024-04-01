using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "SELECT    (TIPOPROD.NOMBRE) [TIPO PRODUCTOS], SUM (DETALLEVENTA.CANTIDAD) [TOTAL VENDIDOS]\r\nFROM         PRODUCTO INNER JOIN\r\n                      DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO INNER JOIN\r\n                      TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD\r\nGROUP BY TIPOPROD.NOMBRE\r\nORDER BY [TOTAL VENDIDOS]";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "','" 
                                                         + proveedor.Telefono + "','" 
                                                         + proveedor.Direccion + "','"
                                                         + proveedor.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        Proveedor p = new Proveedor();
        public Proveedor ObtenerProveedorIdDal(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.Direccion = tabla.Rows[0]["direccion"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarProveedorDal(Proveedor p)
        {
            string consulta = "update proveedor set nombre='" + p.Nombre + "'," +
                                                        "telefono='" + p.Telefono + "'," +
                                                        "direccion='" + p.Direccion + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idproveedor=" + p.IdProveedor;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
