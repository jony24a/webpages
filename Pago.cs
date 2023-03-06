using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Pago : Form
    {
        ConexionPago ConexPago = new ConexionPago();

        public Pago()
        {
            InitializeComponent();
        }

        private void TxtCodCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            ConexPago.conexion();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            ConexPago.conexion();
            DataTable misDatos = new DataTable();

            try
            {
                misDatos = ConexPago.MostrarDatos();
                DGV.DataSource = misDatos;
                ConexPago.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de Datos {ex.Message}");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int CodPed = int.Parse(TxtCodPed.Text);
            string FecPed = TxtFecPed.Text;
            string FecEsp = TxtFecEsp.Text;
            string FecEnt = TxtFecEnt.Text;
            string Estado = TxtEst.Text;
            string Com = TxtCom.Text;
            int CodCli = int.Parse(TxtCli.Text);

            ConexPago.conexion();
            ConexPago.ModificarDatos(CodPed, FecPed, FecEsp, FecEnt, Estado, Com, CodCli);
            ConexPago.CerrarConexion();

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            int CodPed = int.Parse(TxtCodPed.Text);
            string FecPed = TxtFecPed.Text;
            string FecEsp = TxtFecEsp.Text;
            string FecEnt = TxtFecEnt.Text;
            string Estado = TxtEst.Text;
            string Com = TxtCom.Text;
            int CodCli = int.Parse(TxtCli.Text);

            ConexPago.conexion();
            ConexPago.InsertarDatos(CodPed, FecPed, FecEsp, FecEnt, Estado, Com, CodCli);
            ConexPago.CerrarConexion();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            int CodPed = int.Parse(TxtCodPed.Text);

            ConexPago.conexion();
            ConexPago.EliminarDatos(CodPed);
            ConexPago.CerrarConexion();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el programa");
            Application.Exit();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagoCorrecto pagoCorrecto = new PagoCorrecto();
            pagoCorrecto.Show();
        }
    }
}
