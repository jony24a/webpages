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
    internal class Conexion1
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
            string Query = "Select * from Cliente";

            OracleCommand comando = new OracleCommand(Query, RegresarConexion());
            OracleDataAdapter OraAdap = new OracleDataAdapter();

            OraAdap.SelectCommand = comando;
            OraAdap.Fill(DatosTabla);
            return DatosTabla;
        }

        public void InsertarDatos(int CodCli, string Nombre, string NomCon, string ApeCon, string Tel, string Fax, string LinDir1, string LinDir2, string Ciudad, string Region, string Pais, string CodPos, int CodEmp, string LimCre)
        {
            OracleCommand command;
            string Query = "Insert into cliente (CODIGO_CLIENTE, NOMBRE_CLIENTE, NOMBRE_CONTACTO, APELLIDO_CONTACTO, TELEFONO, FAX, LINEA_DIRECCION1, LINEA_DIRECCION2, CIUDAD, REGION, PAIS, CODIGO_POSTAL, CODIGO_EMPLEADO_REP_VENTAS, LIMITE_CREDITO) values ('" + CodCli + "','" + Nombre + "','" + NomCon + "','" + ApeCon + "','" + Tel + "','" + Fax + "','" + LinDir1 + "','" + LinDir2 + "','" + Ciudad + "','" + Region + "','" + Pais + "','" + CodPos + "','" + CodPos + "','" + LimCre + "')";
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

        public void EliminarDatos(int CodCli)
        {
            OracleCommand command;
            string Query = "Delete from cliente where CODIGO_CLIENTE = '" + CodCli + "'";
            try
            {
                command = new OracleCommand(Query, RegresarConexion());
                OracleDataAdapter OraAd = new OracleDataAdapter();
                OraAd.DeleteCommand = command;
                OraAd.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show($"Se elimino {CodCli} Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al Elminar {ex.Message}");
            }

        }

        public void ModificarDatos(int CodCli, string Nombre, string NomCon, string ApeCon, string Tel, string Fax, string LinDir1, string LinDir2, string Ciudad, string Region, string Pais, string CodPos, int CodEmp, string LimCre)
        {
            OracleCommand command;
            string Query = "Update cliente set NOMBRE_CLIENTE = '" + Nombre + "', NOMBRE_CONTACTO = '" + NomCon + "', APELLIDO_CONTACTO = '" + ApeCon + "', TELEFONO = '" + Tel + "', FAX = '" + Fax + "', LINEA_DIRECCION1 = '" + LinDir1 + "', LINEA_DIRECCION2 = '" + LinDir2 + "', CIUDAD = '" + Ciudad + "', REGION = '" + Region + "', PAIS = '" + Pais + "', CODIGO_POSTAL = '" + CodPos + "', CODIGO_EMPLEADO_REP_VENTAS = '" + CodEmp + "', LIMITE_CREDITO = '" + LimCre + "'where CODIGO_CLIENTE = '" + CodCli + "'";
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
