using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace People.Consume
{
    public partial class Index : Form
    {
        public bool Autentic = false;
        public Index()
        {
            InitializeComponent();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }
        private async void BtnAutenticar_MouseClick(object sender, MouseEventArgs e)
        {
            List<Autentication.Models.People> ListPeople;
                    Pesquisar pesquisar = new Pesquisar();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:62216/api/people");
                var resp = await client.GetAsync("http://localhost:62216/api/people");

                string dados = await resp.Content.ReadAsStringAsync();

                ListPeople = new JavaScriptSerializer().Deserialize<List<Autentication.Models.People>>(dados);

                Autentication.Models.People people = new Autentication.Models.People();
                people.Cpf = TbCpf.Text;
                people.Nome = TbNome.Text;

                Autentic = people.ValidateAcess(ListPeople, people.Nome, people.Cpf);

                if (Autentic)
                {
                    this.Hide();
                    pesquisar.Show();
                }
                else
                {
                    MessageBox.Show("Nome ou Cpf Inválidos", "Erro de acesso");
                }

            }
        }
    }
    
}
