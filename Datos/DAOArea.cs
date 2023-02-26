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
    public class DAOArea
    {
        conexion conex = new conexion();
        public List <Area> ObtenerTodos() 
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select * from areas");
                    comando.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Area> lista = new List<Area>();
                    Area objArea = null;
                    if (resultado.Rows.Count==0)
                    {
                        MySqlCommand comando2 = new MySqlCommand("drop table Areas;");
                        MySqlCommand comando3 = new MySqlCommand("DBCC CHECKIDENT ('Areas');");
                        comando2.ExecuteNonQuery();
                        comando3.ExecuteNonQuery();
                    }
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objArea = new Area();
                        objArea.id = Convert.ToInt32(fila["id"].ToString());
                        objArea.nombre = fila["nombre"].ToString();
                        objArea.ubicacion = fila["ubicacion"].ToString();
                        lista.Add(objArea);
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
                    Area obj = new Area();
                    MySqlCommand comando = new MySqlCommand("delete areas where id = @id;");
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    int filasAgregadas = Convert.ToInt32(comando.ExecuteScalar());
                    return true;
                }
                else
                {
                    throw new Exception("No se pudo eliminar el producto");
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

        public int modificar(Area obj)
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("UPDATE Areas SET nombre = @nombre, ubicacion = @ubicacion where id = @id;");
                    Console.WriteLine("Nombre: " + obj.nombre);
                    Console.WriteLine("Ubicacion: " + obj.ubicacion + " ID: " + obj.id);
                    comando.Parameters.AddWithValue("@nombre", obj.nombre.ToString());
                    comando.Parameters.AddWithValue("@ubicacion", obj.ubicacion.ToString());
                    comando.Parameters.AddWithValue("@id",obj.id);
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
                throw new Exception();
            }
            finally
            {
                conex.desconectar();
            }
        }

        public int agregar(Area areas)
        {
            try
            {
                if (conex.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"INSERT INTO Areas (nombre, ubicacion) VALUES(@nombre, @ubicacion);");
                    comando.Parameters.AddWithValue("@nombre", areas.nombre);
                    comando.Parameters.AddWithValue("@ubicacion", areas.ubicacion);
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
