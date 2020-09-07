using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Concecionaria;
using Microsoft.VisualBasic;

namespace ConcecionariaConADOdesconectado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccesoSQL Acceso;
        private void Form1_Load(object sender, EventArgs e)
        {
            Acceso = new AccesoSQL();
        }

        private void btbAñadirAutomovil_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = DefinirPatente();
                int año = int.Parse(Interaction.InputBox("Ingresar el Año del Auto", "Ingresar Automovil Nuevo"));
                string marca = Interaction.InputBox("Ingresar Marca del Auto", "Ingresar Automovil Nuevo");
                string modelo = Interaction.InputBox("Ingresar Modelo del Auto", "Ingresar Automovil Nuevo");
                int precio = int.Parse(Interaction.InputBox("Ingresar el Costo del Auto", "Ingresar Automovil Nuevo"));


                Auto auto = new Auto(patente, año, marca, modelo, precio,"EnVenta");
                if (Acceso.AñadirAuto(auto))
                {
                    MessageBox.Show("Automovil ingresado con exito");
                    ActualizarDGV(true);
                }
                else
                {
                    MessageBox.Show("No hay conexion con la base de datos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error"); 
            }   
        }

        private void btbAñadirCliente_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingresar su nombre", "Formulario de nuevo Cliente");
            string apellido = Interaction.InputBox("Ingresar su apellido", "Formulario de nuevo Cliente");
            int dni = int.Parse(Interaction.InputBox("Ingresar su DNI", "Formulario de nuevo Cliente"));
            

            try
            {
                Cliente cliente = new Cliente(nombre,apellido,dni);
                if (Acceso.AñadirCliente(cliente))
                {
                    MessageBox.Show("Cliente ingresado con exito");
                    ActualizarDGV(true);
                }
                else
                {
                    MessageBox.Show("No hay conexion con la base de datos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btbVenderAuto_Click(object sender, EventArgs e)
        {
            try
            {
                var filaAuto = dgvAutosDisponibles.CurrentRow.Index;
                var filaCliente = dgvClientes.CurrentRow.Index;
                string patente = dgvAutosDisponibles.Rows[filaAuto].Cells[0].Value.ToString();
                int dni = int.Parse(dgvClientes.Rows[filaCliente].Cells[2].Value.ToString());


                Acceso.VenderAuto(new VentaRegistrada(patente,dni));
                ActualizarDGV(true);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, intente mas tarde");
            }



            
        }

        private void btbConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Acceso.Conectar())
                {
                    lblEstadoDeConexion.Text = "Estado De Conexion = True";
                    ActualizarDGV(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexion, algo fallo");
            }
        }

        private void btbDesconectar_Click(object sender, EventArgs e)
        {
            Acceso.Desconectar();
            lblEstadoDeConexion.Text= "Estado De Conexion = False";
            ActualizarDGV(false);
        }

        private string DefinirPatente()
        {
            string patletras = Interaction.InputBox("Ingresar las 3 letras de la patente", "Ingresar Automovil Nuevo");
            int patnumeros = int.Parse(Interaction.InputBox("Ingresar los 3 numeros de la patente", "Ingresar Automovil Nuevo"));
            while (patletras.Length != 3 && patnumeros.ToString().Length != 3)
            {
                MessageBox.Show("Ocurrio un error, volver a colocar la patente", "Ingresar Automovil Nuevo");
                patletras = Interaction.InputBox("Ingresar las 3 letras de la patente", "Ingresar Automovil Nuevo");
                patnumeros = int.Parse(Interaction.InputBox("Ingresar los 3 numeros de la patente", "Ingresar Automovil Nuevo"));
            }
            string patente = patletras + "-" + patnumeros;
            return patente;
        }

        private void ActualizarDGV(bool EstadoBaseDeDatos)
        {
            dgvHistorialCompletos.DataSource = null;
            if (EstadoBaseDeDatos)
            {
                //reinicio el estado de los dgv
                dgvAutosDisponibles.DataSource = null;
                dgvClientes.DataSource = null;
                dgvAutosVendidos.DataSource = null;

                dgvAutosDisponibles.DataSource = Acceso.ObtenerAutosEnVenta();
                dgvClientes.DataSource = Acceso.ObtenerClientes();
                dgvAutosVendidos.DataSource = Acceso.ObtenerVentas();
            }
            else
            {
                //desactivo los dgv
                dgvAutosDisponibles.DataSource = null;
                dgvClientes.DataSource = null;
                dgvAutosVendidos.DataSource = null;
            }
        }

        private void btbCompletoHistorial_Click(object sender, EventArgs e)
        {
            dgvHistorialCompletos.DataSource = null;
            dgvHistorialCompletos.DataSource = Acceso.ObtenerAutosHistorialCompleto();
        }
    }
}
