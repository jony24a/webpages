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
    internal class ConexionPagoCorrecto
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
            string Query = "Select * from Pago";

            OracleCommand comando = new OracleCommand(Query, RegresarConexion());
            OracleDataAdapter OraAdap = new OracleDataAdapter();

            OraAdap.SelectCommand = comando;
            OraAdap.Fill(DatosTabla);
            return DatosTabla;
        }

        public void InsertarDatos(int CodCli, string ForPag, string IdTra, string FecPag, string Total)
        {
            OracleCommand command;
            string Query = "Insert into Pago (CODIGO_CLIENTE, FORMA_PAGO, ID_TRANSACCION, FECHA_PAGO, TOTAL) values ('" + CodCli + "','" + ForPag + "','" + IdTra + "','" + FecPag + "','" + Total + "')";
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

        public void ModificarDatos(int CodCli, string ForPag, string IdTra, string FecPag, string Total)
        {
            OracleCommand command;
            string Query = "Update Pago set CODIGO_CLIENTE = '" + CodCli + "', FORMA_PAGO = '" + ForPag + "', FECHA_PAGO = '" + FecPag + "', TOTAL = '" + Total + "'where ID_TRANSACCION = '" + IdTra + "'";
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

        public void EliminarDatos(string IdTra)
        {
            OracleCommand command;
            string Query = "Delete from Pago where ID_TRANSACCION = '" + IdTra + "'";
            try
            {
                command = new OracleCommand(Query, RegresarConexion());
                OracleDataAdapter OraAd = new OracleDataAdapter();
                OraAd.DeleteCommand = command;
                OraAd.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show($"Se elimino {IdTra} Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Elminar {ex.Message}");
            }
        }
    }
}
