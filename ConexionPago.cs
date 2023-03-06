using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Final
{
    internal class ConexionPago
    {
        private OracleConnection ObjCon;
        private String Servidor = "localhost", Usuario = "system", Pass = "123456";

        public void conexion()
        {
            try
            {
                ObjCon = new OracleConnection($"Data Source = {Servidor}; user id = {Usuario}; password = {Pass}");
                ObjCon.Open();
                MessageBox.Show($"Se ha conectado con exito {ObjCon.State}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar {ex.Message}");
            }
        }

        public void CerrarConexion()
        {
            ObjCon.Close();
        }

        public OracleConnection RegresarConexion()
        {
            return ObjCon;
        }

        public DataTable MostrarDatos()
        {
            DataTable DatosTabla = new DataTable();
            string Query = "Select * from Pedido";

            OracleCommand comando = new OracleCommand(Query, RegresarConexion());
            OracleDataAdapter OraAdap = new OracleDataAdapter();

            OraAdap.SelectCommand = comando;
            OraAdap.Fill(DatosTabla);
            return DatosTabla;
        }

        public void InsertarDatos(int CodPed, string FecPed, string FecEsp, string FecEnt, string Estado ,string Com, int CodCli)
        {
            OracleCommand command;
            string Query = "Insert into Pedido (CODIGO_PEDIDO, FECHA_PEDIDO, FECHA_ESPERADA, FECHA_ENTREGA, ESTADO, COMENTARIOS, CODIGO_CLIENTE) values ('" + CodPed + "','" + FecPed + "','" + FecEsp + "','" + FecEnt + "','" +Estado + "','" + Com + "','" + CodCli + "')";
            try
            {
                command = new OracleCommand(Query, RegresarConexion());
                command.ExecuteNonQuery();
                MessageBox.Show("Datos insertados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar {ex.Message}");
            }
        }

        public void EliminarDatos(int CodPed)
        {
            OracleCommand command;
            string Query = "Delete from Pedido where CODIGO_PEDIDO = '" + CodPed + "'";
            try
            {
                command = new OracleCommand(Query, RegresarConexion());
                OracleDataAdapter OraAd = new OracleDataAdapter();
                OraAd.DeleteCommand = command;
                OraAd.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show($"Se elimino {CodPed} Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Elminar {ex.Message}");
            }
        }

        public void ModificarDatos(int CodPed, string FecPed, string FecEsp, string FecEnt, string Estado, string Com, int CodCli)
        {
            OracleCommand command;
            string Query = "Update Pedido set FECHA_PEDIDO = '" + FecPed + "', FECHA_ESPERADA = '" + FecEsp + "', FECHA_ENTREGA = '" + FecEnt + "', ESTADO = '" + Estado + "', COMENTARIOS = '" + Com + "', CODIGO_CLIENTE = '" + CodCli + "'where CODIGO_PEDIDO = '" + CodPed + "'";
            try
            {
                command = new OracleCommand(Query, RegresarConexion());
                OracleDataAdapter Upda = new OracleDataAdapter();
                Upda.UpdateCommand = command;
                Upda.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show($"Se modificaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Modificar {ex.Message}");

            }
        }
    }
}
