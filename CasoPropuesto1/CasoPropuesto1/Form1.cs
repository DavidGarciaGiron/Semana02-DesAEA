using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CasoPropuesto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString);

        //metodo de listado
        public void ListaPedidos()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Listado_Pedidos", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        DgListado.DataSource = df.Tables["Pedidos"];
                        LblCantidad.Text = df.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }
        }

        public void BusquedaPedidos()
        {
            using (SqlDataAdapter Df = new SqlDataAdapter("Usp_Busqueda_Pedidos", cn))
            {
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.Value = txtFiltro.Text;
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.ParameterName = "@empleado";

                Df.SelectCommand.Parameters.Add(sqlParameter);
                Df.SelectCommand.CommandType = CommandType.StoredProcedure;

                using (DataSet Da = new DataSet())
                {
                    Df.Fill(Da, "Pedidos");
                    DgListado.DataSource = Da.Tables["Pedidos"];
                    LblCantidad.Text = Da.Tables["Pedidos"].Rows.Count.ToString();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ListaPedidos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaPedidos();
        }
    }
}
