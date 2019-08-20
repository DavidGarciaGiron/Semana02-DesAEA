using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CasoPropuesto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["neptuno"].ConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Listado_Pedidos_2", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "pedidos");
                        DgListado.DataSource = df.Tables["pedidos"];
                    }
                }
            }
        }

        private void listarDetalleProducto()
        {
            int codigo;
            codigo = Convert.ToInt32(DgListado.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido_2", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idPedido", codigo);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Detalles");
                        DgDetalle.DataSource = df.Tables["Detalles"];
                    }
                }
            }
        }

        private void DgListado_DoubleClick(object sender, EventArgs e)
        {
            listarDetalleProducto();
        }
    }
}
