using BLL;
using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();

            }
        }

        //BANCO DE DADOS E PROC
        //    https://pastebin.com/xqNNnane

        protected void BotaoInCluir(object sender, EventArgs e)
        {


            //Validação dos campos
            if (string.IsNullOrEmpty(TBoxNome.Text) || (string.IsNullOrEmpty(TboxEnd.Text)))
            {
                LblResult.Visible = true;
                LblResult.Text = "Por favor, Digite todos os dados!!!";

            }
            else
            {
                Regra pBAL = new Regra();
                string ParametroNOME = TBoxNome.Text;
                string ParametroEND = TboxEnd.Text;

                try
                {
                    pBAL.Inserir_Dados(ParametroNOME, ParametroEND);

                }
                catch (Exception ee)
                {
                    ee.Message.ToString();
                }

                {
                    pBAL = null;
                }
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Registro incluido com sucesso.')", true);
                //LblResult.Visible = true;
                //LblResult.Text = "Dados cadastrados com sucesso!!!";
            }

            //limpar campos
            Response.Redirect(Request.Path);


        }


        private void BindGrid()
        {
            string String_Sql = ConfigurationManager.ConnectionStrings["String_Sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(String_Sql))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT [Nome], [Email] FROM [Users]"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
    }
}