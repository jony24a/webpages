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
    public partial class PagoCorrecto : Form
    {
        ConexionPagoCorrecto ConexPagoCor = new ConexionPagoCorrecto();
        public PagoCorrecto()
        {
            InitializeComponent();
        }

        private void cliente_Click(object sender, EventArgs e)
        {

        }

        private void PagoCorrecto_Load(object sender, EventArgs e)
        {

        }

        private void BtnConexion_Click(object sender, EventArgs e)
        {
            ConexPagoCor.conexion();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            ConexPagoCor.conexion();
            DataTable misDatos = new DataTable();

            try
            {
                misDatos = ConexPagoCor.MostrarDatos();
                DGV.DataSource = misDatos;
                ConexPagoCor.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de Datos {ex.Message}");
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            int CodCli = int.Parse(TxtCodCli.Text);
            string ForPag = TxtForPag.Text;
            string IdTra = TxtIdTra.Text;
            string FecPag = TxtFecPag.Text;
            string Total = TxtTot.Text;

            ConexPagoCor.conexion();
            ConexPagoCor.InsertarDatos(CodCli, ForPag, IdTra, FecPag, Total);
            ConexPagoCor.CerrarConexion();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int CodCli = int.Parse(TxtCodCli.Text);
            string ForPag = TxtForPag.Text;
            string IdTra = TxtIdTra.Text;
            string FecPag = TxtFecPag.Text;
            string Total = TxtTot.Text;

            ConexPagoCor.conexion();
            ConexPagoCor.ModificarDatos(CodCli, ForPag, IdTra, FecPag, Total);
            ConexPagoCor.CerrarConexion();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            string IdTra = TxtIdTra.Text;

            ConexPagoCor.conexion();
            ConexPagoCor.EliminarDatos(IdTra);
            ConexPagoCor.CerrarConexion();
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

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pago TablaPago = new Pago();
            TablaPago.Show();
        }
    }
}
