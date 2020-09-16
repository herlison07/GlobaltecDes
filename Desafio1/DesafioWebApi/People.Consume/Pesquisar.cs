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
        Index index = new Index();
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
                client.BaseAddress = new Uri("http://localhost:62216/api/people");
                var resp = await client.GetAsync("http://localhost:62216/api/people");

                string dados = await resp.Content.ReadAsStringAsync();

                List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                DgvPeople.DataSource = ListPeople;
            }
        }

        private async void BtnExecutar_ClickAsync(object sender, EventArgs e)
        {
            if (index.Autentic == true)
            {
                string CBFilter = CbFiltro.SelectedItem.ToString();
                string TBText = TbFiltro.Text;
                DgvPeople.Refresh();
                #region //Pesquisar
                if (BtnPesquisar.BackColor == Color.FromArgb(0, 255, 0, 100) && CBFilter == "Nenhum")
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:62216/api/people/");
                        var resp = await client.GetAsync("");

                        string dados = await resp.Content.ReadAsStringAsync();

                        List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                        DgvPeople.DataSource = ListPeople;
                    }
                }
                else if (BtnPesquisar.BackColor == Color.FromArgb(0, 255, 0, 100) && CBFilter == "UF")
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:62216/people/uf/" + TBText);
                        var resp = new HttpResponseMessage();
                        try
                        {
                            resp = await client.GetAsync("http://localhost:62216/people/uf/" + TBText);

                            string dados = await resp.Content.ReadAsStringAsync();

                            List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                            DgvPeople.DataSource = ListPeople;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(resp.ToString(), "Erro");
                        }
                    }
                }
                else if (BtnPesquisar.BackColor == Color.FromArgb(0, 255, 0, 100) && CBFilter == "CPF")
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:62216/people/cpf/" + TBText);
                        var resp = new HttpResponseMessage();
                        try
                        {
                            resp = await client.GetAsync("http://localhost:62216/people/cpf/" + TBText);

                            string dados = await resp.Content.ReadAsStringAsync();

                            List<Autentication.Models.People> ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);
                            DgvPeople.DataSource = ListPeople;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(resp.ToString(), "Erro");
                        }
                    }
                }
                #endregion
                if (BtnAlterar.BackColor == Color.FromArgb(0, 255, 0, 100))
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("http://localhost:62216/api/people");

                        Autentication.Models.People people = new Autentication.Models.People();
                        people.Cod = int.Parse(TbCod.Text);
                        people.Cpf = TbCpf.Text;
                        people.Nome = TbNome.Text;
                        people.Uf = TbUf.SelectedItem.ToString();
                        people.Nascimento = TbNasc.Value;

                        try
                        {
                            var resp = await client.PutAsJsonAsync("http://localhost:62216/api/people", people);
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
                        client.BaseAddress = new Uri("http://localhost:62216/api/people");

                        Autentication.Models.People people = new Autentication.Models.People();
                        people.Cod = int.Parse(TbCod.Text);
                        people.Cpf = TbCpf.Text;
                        people.Nome = TbNome.Text;
                        people.Uf = TbUf.SelectedItem.ToString();
                        people.Nascimento = TbNasc.Value;

                        try
                        {
                            var resp = await client.DeleteAsync("http://localhost:62216/people/" + people.Cod);
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
            else
            {
                MessageBox.Show("Não Autenticado", "Erro");
                this.Close();
                index.Show();
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
    }
}
