using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Concecionaria;

namespace ConcecionariaConADOdesconectado
{
    public class AccesoSQL
    {
        SqlConnection Conexion;
        private string sqlDirecction = @"Data Source=DESKTOP-4EMC1D1;Initial Catalog=Concesionaria;Integrated Security=True";

        #region Añadir Autos y Clientes a la base de datos
        public bool AñadirAuto(Auto auto)
        {
            if (Conexion == null || Conexion.State != System.Data.ConnectionState.Open) 
            {
                return false;
            }

            using (var comando = new SqlCommand())
            {
                comando.Connection = Conexion;
                comando.CommandText = "INSERT INTO AUTOS(Patente,Año,Marca,Modelo,Precio,Estado) VALUES(@patente,@año,@marca,@modelo,@precio,@estado)";

                comando.Parameters.AddWithValue("@patente", auto.Patente);
                comando.Parameters.AddWithValue("@año", auto.Año);
                comando.Parameters.AddWithValue("@marca", auto.Marca);
                comando.Parameters.AddWithValue("@modelo", auto.Modelo);
                comando.Parameters.AddWithValue("@precio", auto.Precio);
                comando.Parameters.AddWithValue("@estado", auto.Estado);

                comando.ExecuteNonQuery();
            }

            return true;
        }
        public bool AñadirCliente(Cliente cliente)
        {
            if (Conexion == null || Conexion.State != System.Data.ConnectionState.Open)
            {
                return false;
            }

            using (var comando = new SqlCommand())
            {
                comando.Connection = Conexion;
                comando.CommandText = "INSERT INTO CLIENTES(Nombre,Apellido,Dni) VALUES(@nombre,@apellido,@dni)";

                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);

                comando.ExecuteNonQuery();
            }
            return true;
        }
        #endregion

        //VenderAutos
        public void VenderAuto(VentaRegistrada VR)
        {
            using (var comando1 = new SqlCommand())
            {
                comando1.Connection = Conexion;
                comando1.CommandText = "UPDATE AUTOS SET Estado = 'Vendido' WHERE Patente = '" + VR.Patente + "'";
                comando1.ExecuteNonQuery();
            }

            using (var comando2 = new SqlCommand())
            {
                comando2.Connection = Conexion;
                comando2.CommandText = "INSERT INTO VENTAAUTOCLIENTE(Patente,Dni) VALUES(@patente,@dni)";

                comando2.Parameters.AddWithValue("@patente", VR.Patente);
                comando2.Parameters.AddWithValue("@dni", VR.Dni);

                comando2.ExecuteNonQuery();
            }
        }

        #region LeerAuto, Leer Cliente y Leer AutosVendidos
        public List<Auto> ObtenerAutosHistorialCompleto()
        {
            List<Auto> Autos = new List<Auto>();
            using (var comando = new SqlCommand())
            {
                comando.Connection = Conexion;
                comando.CommandText = "SELECT * FROM AUTOS";
                using (var Lector = comando.ExecuteReader())
                {
                    while (Lector.Read())
                    {
                        string patente = Lector.GetString(0);
                        var año = int.Parse((Lector["Año"].ToString()));
                        string marca = Lector.GetString(2).ToString();
                        string modelo = Lector.GetString(3).ToString();
                        var Precio = int.Parse((Lector["Precio"].ToString()));
                        string Estado = Lector.GetString(5).ToString();
                        Autos.Add(new Auto(patente, año, marca, modelo, Precio, Estado));
                    }
                }
            }
            return Autos;
        }
        public List<Auto> ObtenerAutosEnVenta()
        {
            List<Auto> Autos = new List<Auto>();
            using (var comando = new SqlCommand())
            {
                comando.Connection = Conexion;
                comando.CommandText = "SELECT * FROM AUTOS WHERE Estado = 'EnVenta'";
                using (var Lector = comando.ExecuteReader()) 
                {
                    while (Lector.Read())
                    {
                        string patente = Lector.GetString(0);
                        var año = int.Parse((Lector["Año"].ToString()));
                        string marca = Lector.GetString(2).ToString();
                        string modelo = Lector.GetString(3).ToString();
                        var Precio = int.Parse((Lector["Precio"].ToString()));
                        Autos.Add(new Auto(patente, año, marca, modelo, Precio,"EnVenta"));
                    }
                }         
            }
            return Autos;
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> cliente = new List<Cliente>();
            using (var comando = new SqlCommand())
            {
                comando.Connection = Conexion;
                comando.CommandText = "SELECT * FROM CLIENTES";
                using (var Lector = comando.ExecuteReader())
                {
                    while (Lector.Read())
                    {
                        string nombre = Lector.GetString(1);
                        string apellido = Lector.GetString(2);
                        int dni = int.Parse((Lector["Dni"].ToString()));
                        cliente.Add(new Cliente(nombre, apellido, dni));
                    }
                }
            }
            return cliente;
        }
        public List<VentaRegistrada> ObtenerVentas()
        {
            List<VentaRegistrada> AutosVendidos = new List<VentaRegistrada>();
            using (var comando = new SqlCommand())
            {
                comando.Connection = Conexion;
                comando.CommandText = "SELECT * FROM VENTAAUTOCLIENTE";
                using (var Lector = comando.ExecuteReader())
                {
                    while (Lector.Read())
                    {
                        int dni = int.Parse((Lector["Dni"].ToString()));
                        string patente = Lector.GetString(1);
                        AutosVendidos.Add(new VentaRegistrada(patente,dni));
                    }
                }
            }
            return AutosVendidos;
        }
        #endregion

        #region Conectar y Desconectar de la Base de datos
        public bool Conectar()
        {         
            //Evita crear una nueva conexion cunado ya tenemos una activa
            if (Conexion != null && Conexion.State == System.Data.ConnectionState.Open)
            {
                return false;
            }

            Conexion = new SqlConnection();
            Conexion.ConnectionString = sqlDirecction;
            Conexion.Open();
            return true;
        }
        public void Desconectar()
        {
            Conexion.Close();
            Conexion.Dispose();
            GC.Collect();
        }
        #endregion
    }
}
