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

namespace ConsumirWebApi
{
    public partial class Pesquisar : Form
    {
        AccessLink uri = new AccessLink();
        Autenticar index = new Autenticar();
        public Pesquisar()
        {
            Pesq();
            InitializeComponent();
            BtnPesquisar.BackColor = Color.FromArgb(0, 255, 0, 100);
            BtnAlterar.BackColor = Color.FromArgb(100, 250, 0, 100);
            BtnExcluir.BackColor = Color.FromArgb(100, 250, 0, 100);
            TbNasc.Enabled = false;
            TbNome.Enabled = false;
            TbCpf.Enabled = false;
            TbUf.Enabled = false;
        }

        public async void Pesq()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                client.BaseAddress = new Uri(uri.uri + "api/people");
                var resp = await client.GetAsync(uri.uri + "api/people");

                string dados = await resp.Content.ReadAsStringAsync();

                List<People> ListPeople = new JavaScriptSerializer().Deserialize<List<People>>(dados);
                DgvPeople.DataSource = ListPeople;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro"); 
                }
            }
        }

        private async void BtnExecutar_ClickAsync(object sender, EventArgs e)
        {
            string CBFilter = CbFiltro.SelectedItem.ToString();
            string TBText = TbFiltro.Text;
            DgvPeople.Refresh();
            #region //Pesquisar
            if (BtnPesquisar.BackColor == Color.FromArgb(0, 255, 0, 100) && CBFilter == "Nenhum")
            {
                Pesq();
            }
            else if (BtnPesquisar.BackColor == Color.FromArgb(0, 255, 0, 100) && CBFilter == "UF")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri.uri + "people /uf/" + TBText);
                    var resp = new HttpResponseMessage();
                    try
                    {
                        resp = await client.GetAsync(uri.uri + "people/uf/" + TBText);

                        string dados = await resp.Content.ReadAsStringAsync();

                        List<People> ListPeople = new JavaScriptSerializer().Deserialize<List<People>>(dados);
                        DgvPeople.DataSource = ListPeople;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                }
            }
            else if (BtnPesquisar.BackColor == Color.FromArgb(0, 255, 0, 100) && CBFilter == "CPF")
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri.uri + "people /cpf/" + TBText);
                    var resp = new HttpResponseMessage();
                    try
                    {
                        resp = await client.GetAsync(uri.uri + "people/cpf/" + TBText);

                        string dados = await resp.Content.ReadAsStringAsync();

                        List<People> ListPeople = new JavaScriptSerializer().Deserialize<List<People>>(dados);
                        DgvPeople.DataSource = ListPeople;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro");
                    }
                }
            }
            #endregion
            if (BtnAlterar.BackColor == Color.FromArgb(0, 255, 0, 100))
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri.uri + "api/people");

                    People people = new People();
                    people.Cod = int.Parse(TbCod.Text);
                    people.Cpf = TbCpf.Text;
                    people.Nome = TbNome.Text;
                    people.Uf = TbUf.SelectedItem.ToString();
                    people.Nascimento = TbNasc.Value;

                    try
                    {
                        var resp = await client.PutAsJsonAsync(uri.uri + "api/people", people);
                        MessageBox.Show(people.ToString(), "Dados Alterados");
                        Pesq();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Erro Ao Alterar dados");

                    }

                }
            }
            if (BtnExcluir.BackColor == Color.FromArgb(0, 255, 0, 100))
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri.uri + "api/people");

                    People people = new People();
                    people.Cod = int.Parse(TbCod.Text);
                    people.Cpf = TbCpf.Text;
                    people.Nome = TbNome.Text;
                    people.Uf = TbUf.SelectedItem.ToString();
                    people.Nascimento = TbNasc.Value;

                    try
                    {
                        var resp = await client.DeleteAsync(uri.uri + "people/" + people.Cod);
                        MessageBox.Show(people.ToString(), "Pessoa Deletada");
                        Pesq();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Erro Ao Deletar");

                    }
                }
            }
        }

        private void BtnPesquisar_MouseClick(object sender, MouseEventArgs e)
        {
            BtnAlterar.BackColor = Color.FromArgb(100, 250, 0, 100);
            BtnExcluir.BackColor = Color.FromArgb(100, 250, 0, 100);
            BtnPesquisar.BackColor = Color.FromArgb(0, 255, 0, 100);
            TbNasc.Enabled = false;
            TbNome.Enabled = false;
            TbCpf.Enabled = false;
            TbUf.Enabled = false;
        }

        private void BtnAlterar_MouseClick(object sender, MouseEventArgs e)
        {
            BtnAlterar.BackColor = Color.FromArgb(0, 255, 0, 100);
            BtnExcluir.BackColor = Color.FromArgb(100, 250, 0, 100);
            BtnPesquisar.BackColor = Color.FromArgb(100, 250, 0, 100);
            TbNasc.Enabled = true;
            TbNome.Enabled = true;
            TbCpf.Enabled = true;
            TbUf.Enabled = true;
        }

        private void BtnExcluir_MouseClick(object sender, MouseEventArgs e)
        {
            BtnAlterar.BackColor = Color.FromArgb(100, 250, 0, 100);
            BtnExcluir.BackColor = Color.FromArgb(0, 255, 0, 100);
            BtnPesquisar.BackColor = Color.FromArgb(100, 250, 0, 100);
            TbNasc.Enabled = false;
            TbNome.Enabled = false;
            TbCpf.Enabled = false;
            TbUf.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            index.Autentic = false;
            this.Close();
            index.Show();
        }

        private void DgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DgvPeople.CurrentRow.Index;

            TbCod.Text = DgvPeople.Rows[i].Cells["Cod"].Value.ToString();
            TbNome.Text = DgvPeople.Rows[i].Cells["Nome"].Value.ToString();
            TbCpf.Text = DgvPeople.Rows[i].Cells["Cpf"].Value.ToString();
            TbUf.Text = DgvPeople.Rows[i].Cells["Uf"].Value.ToString();
            TbNasc.Value = DateTime.Parse(DgvPeople.Rows[i].Cells["Nascimento"].Value.ToString());
        }

        public class People
        {
            public int Cod { get; set; }
            public string Cpf { get; set; }
            public string Nome { get; set; }
            public string Uf { get; set; }
            public DateTime Nascimento { get; set; }

            public bool ValidateAcess(List<People> People, string User, string pass)
            {
                if ((People.Find(x => x.Nome == User && x.Cpf == pass)) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public override string ToString()
            {
                return (
                    "\nCodigo: " + this.Cod +
                    "\nNome: " + this.Nome +
                    "\nCpf: " + this.Cpf +
                    "\nUf: " + this.Uf +
                    "\nNascimento: " + this.Nascimento.ToString("dd/MM/yyyy")
                 );
            }

        }
    }
}