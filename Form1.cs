using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;

namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        Conexion1 Conex = new Conexion1();
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtConexion_Click(object sender, EventArgs e)
        {
            Conex.conexion();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            int CodCli = int.Parse(TxtCodCli.Text);

            Conex.conexion();
            Conex.EliminarDatos(CodCli);
            Conex.CerrarConexion();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Conex.conexion();
            DataTable misDatos = new DataTable();

            try
            {
                misDatos = Conex.MostrarDatos();
                DGV.DataSource = misDatos;
                Conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de Datos {ex.Message}");
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            int CodCli = int.Parse(TxtCodCli.Text);
            string Nombre = TxtNomCli.Text;
            string NomCon = TxtNomCon.Text;
            string ApeCon = TxtApeCon.Text;
            string Tel = TxtTel.Text;
            string Fax = TxtFax.Text;
            string LinDir1 = TxtDir1.Text;
            string LinDir2 = TxtDir2.Text;
            string Ciudad = TxtCiu.Text;
            string Region = TxtReg.Text;
            string Pais = TxtPais.Text;
            string CodPos = TxtCodPos.Text;
            int CodEmp = int.Parse(TxtCodEmp.Text);
            string LimCre = TxtLimCre.Text;

            Conex.conexion();
            Conex.InsertarDatos(CodCli, Nombre, NomCon, ApeCon, Tel, Fax, LinDir1, LinDir2, Ciudad, Region, Pais, CodPos, CodEmp, LimCre);
            Conex.CerrarConexion();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el programa");
            Application.Exit();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int CodCli = int.Parse(TxtCodCli.Text);
            string Nombre = TxtNomCli.Text;
            string NomCon = TxtNomCon.Text;
            string ApeCon = TxtApeCon.Text;
            string Tel = TxtTel.Text;
            string Fax = TxtFax.Text;
            string LinDir1 = TxtDir1.Text;
            string LinDir2 = TxtDir2.Text;
            string Ciudad = TxtCiu.Text;
            string Region = TxtReg.Text;
            string Pais = TxtPais.Text;
            string CodPos = TxtCodPos.Text;
            int CodEmp = int.Parse(TxtCodEmp.Text);
            string LimCre = TxtLimCre.Text;

            Conex.conexion();
            Conex.ModificarDatos(CodCli, Nombre, NomCon, ApeCon, Tel, Fax, LinDir1, LinDir2, Ciudad, Region, Pais, CodPos, CodEmp, LimCre);
            Conex.CerrarConexion();
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pago TablaPago = new Pago();
            TablaPago.Show();
        }

        private void BtnPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagoCorrecto pagoCorrecto = new PagoCorrecto();
            pagoCorrecto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
