using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace People.Consume
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private async void BtnExecutar_ClickAsync(object sender, EventArgs e)
        {
            string CBFilter = CbFiltro.SelectedText;
            string TBText = TbFiltro.Text;
            #region //Pesquisar
            if (BtnPesquisar.Enabled && CBFilter == "Nenhum")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:62216/api/person");
                    var resp = await client.GetAsync("");

                    string dados = await resp.Content.ReadAsStringAsync();

                    List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                    DgvPeople.DataSource = ListPeople;
                }
            }
            else if (BtnPesquisar.Enabled && CBFilter == "UF")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:62216/api/person/uf/" + TBText);
                    var resp = await client.GetAsync("");

                    string dados = await resp.Content.ReadAsStringAsync();

                    List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                    DgvPeople.DataSource = ListPeople;
                }
            }
            else if (BtnPesquisar.Enabled && CBFilter == "CPF")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:62216/api/person/cpf/" + TBText);
                    var resp = await client.GetAsync("");

                    string dados = await resp.Content.ReadAsStringAsync();

                    List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                    DgvPeople.DataSource = ListPeople;
                }
            }
            #endregion
        }

        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnPesquisar.Enabled = true;
            TbNasc.Enabled = false;
            TbNome.Enabled = false;
            TbCpf.Enabled = false;
            TbUf.Enabled = false;
        }

        private void BtnAlterar_MouseClick(object sender, MouseEventArgs e)
        {
            BtnAlterar.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnPesquisar.Enabled = false;
            TbNasc.Enabled = true;
            TbNome.Enabled = true;
            TbCpf.Enabled = true;
            TbUf.Enabled = true;
        }

        private void BtnExcluir_MouseClick(object sender, MouseEventArgs e)
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = true;
            BtnPesquisar.Enabled = false;
            TbNasc.Enabled = false;
            TbNome.Enabled = false;
            TbCpf.Enabled = false;
            TbUf.Enabled = false;
        }

        private void DgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DgvPeople.CurrentRow.Index;

            TbCod.Text = DgvPeople.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            TbNome.Text = DgvPeople.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            TbCpf.Text = DgvPeople.Rows[e.RowIndex].Cells["Cpf"].Value.ToString();
            TbUf.Text = DgvPeople.Rows[e.RowIndex].Cells["Uf"].Value.ToString();
            TbNasc.Text = DgvPeople.Rows[e.RowIndex].Cells["Nascimento"].Value.ToString();

        }
    }
}
