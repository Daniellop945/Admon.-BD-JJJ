using Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class DAOProductos 
    {
        conexion conex = new conexion();
        public DataTable areas()
        {
            DataTable result = new DataTable();
            if (conex.conectar())
            {
                MySqlCommand comando = new MySqlCommand("Select nombre from Areas;");
                comando.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(result);
            }
            return result;
        }

        public DataTable tipoAdquisicion()
        {
            DataTable result = new DataTable();
            if (conex.conectar())
            {
                MySqlCommand comando = new MySqlCommand("select tipoAdquisicion from Inventario;");
                comando.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(result);
            }
            return result;
        }

        public int id()
        {
            int id = 0;
            if (conex.conectar())
            {
                MySqlCommand comando = new MySqlCommand("select count(*) from inventario");
                comando.ExecuteNonQuery();
                id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
            }
            return id;
        }

        public List<Productos> ObtenerTodos()
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(
                        "select i.id, i.NombreCorto, i.descripcion, i.serie, i.color, i.fechaAdquisicion, a.nombre, i.tipoAdquisicion, i.Observaciones from inventario i Inner Join Areas a ON(i.id = a.id);");
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.ExecuteNonQuery();
                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Productos> lista = new List<Productos>();
                    Productos objProducto = null;
                    //Cuando la consulta si obtuvo resultados la tabla trae filas
                    foreach (DataRow fila in resultado.Rows)
                    {
                        //El nombre de las filas debe coincidir con el de la base de datos
                        objProducto = new Productos();
                        objProducto.id_Inventario = Convert.ToInt32(fila["Id"]);
                        objProducto.nombreCorto = fila["nombreCorto"].ToString();
                        objProducto.descripcion = fila["Descripcion"].ToString();
                        objProducto.serie = fila["Serie"].ToString();
                        objProducto.color = fila["color"].ToString();
                        objProducto.fechaAdquision = fila["fechaAdquisicion"].ToString();
                        objProducto.nombre = fila["nombre"].ToString();
                        objProducto.tipoAdquision = fila["tipoAdquisicion"].ToString();
                        objProducto.observaciones = fila["Observaciones"].ToString();
                        lista.Add(objProducto);
                    }

                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de los productos");
            }
            finally
            {
                conex.desconectar();
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("delete from inventario where id = @id;");
                    comando.Parameters.AddWithValue("@id",id);
                    comando.ExecuteNonQuery();
                    int filasAgregadas = Convert.ToInt32(comando.ExecuteScalar());
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                conex.desconectar();
            }
        }

        public int modificar(Productos productos)
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("UPDATE Inventario SET " +
                        "NombreCorto = @nombreCorto , descripcion = @descripcion, serie = @serie, " +
                        "color = @color, fechaAdquisicion = @fechaAdquisicion, tipoAdquisicion = @tipoAdquisicion, " +
                        "Observaciones = @Observaciones where id = @id;");
                    comando.Parameters.AddWithValue("@nombreCorto", productos.nombreCorto);
                    comando.Parameters.AddWithValue("@descripcion", productos.descripcion);
                    comando.Parameters.AddWithValue("@serie", productos.serie);
                    comando.Parameters.AddWithValue("@color", productos.color);
                    comando.Parameters.AddWithValue("@fechaAdquisicion", productos.fechaAdquision);
                    comando.Parameters.AddWithValue("@tipoAdquisicion", productos.tipoAdquision);
                    comando.Parameters.AddWithValue("@Observaciones", productos.observaciones);
                    comando.Parameters.AddWithValue("@id",productos.id_Inventario);
                    comando.ExecuteNonQuery();
                    int filasAgregadas = Convert.ToInt32(comando.ExecuteScalar());
                    return filasAgregadas;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("excepcion"+ex);
            }
            finally
            {
                conex.desconectar();
            }
        }

        public int agregar(Productos productos)
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"INSERT INTO Inventario (NombreCorto, descripcion, serie, color,fechaAdquisicion, tipoAdquisicion, Observaciones) VALUES(@nombreCorto, @descripcion, @serie, @color,
                    @fechaAdquisicion,@tipoAdquisicion, @Observaciones);");
                    comando.Parameters.AddWithValue("@nombreCorto", productos.nombreCorto);
                    comando.Parameters.AddWithValue("@descripcion", productos.descripcion);
                    comando.Parameters.AddWithValue("@serie", productos.serie);
                    comando.Parameters.AddWithValue("@color", productos.color);
                    comando.Parameters.AddWithValue("@fechaAdquisicion", productos.fechaAdquision);
                    comando.Parameters.AddWithValue("@tipoAdquisicion", productos.tipoAdquision);
                    comando.Parameters.AddWithValue("@Observaciones", productos.observaciones);
                    //Se establece la conexión con la que se ejecutará la consulta
                    comando.ExecuteNonQuery();
                    int filasAgregadas = Convert.ToInt32(comando.ExecuteScalar());
                    return filasAgregadas;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo realizar el registro");
            }
            finally
            {
                conex.desconectar();
            }
        }
    }
}
