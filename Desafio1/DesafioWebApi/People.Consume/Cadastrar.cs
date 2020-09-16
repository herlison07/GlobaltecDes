using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People.Consume
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private async void BtnCadastrar_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapidesafio.gearhostpreview.com/api/people");
                Autentication.Models.People people = new Autentication.Models.People(0, TbCpf.Text, TbNome.Text, CbUf.SelectedItem.ToString(),
                                                         DtpNascimento.Value.Day, DtpNascimento.Value.Month, DtpNascimento.Value.Year);


                try
                {
                    var resp = await client.PostAsJsonAsync("http://webapidesafio.gearhostpreview.com/api/people", people);
                    string ret = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show("Sucesso no cadastro",people.ToString());
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar",ex.Message);
                }
            }
        }
    }
}
