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
    public partial class Autenticar : Form
    {
        AccessLink uri = new AccessLink();
        public bool Autentic = false;
        public Autenticar()
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
            List<P> ListPeople;
            Pesquisar pesquisar = new Pesquisar();

            using (HttpClient client = new HttpClient())
            {
                try
                {

                string link = uri.uri + "api/people";

                client.BaseAddress = new Uri(uri.uri + "api/people");
                var resp = await client.GetAsync(uri.uri + "api/people");

                string dados = await resp.Content.ReadAsStringAsync();

                ListPeople = new JavaScriptSerializer().Deserialize<List<P>>(dados);

                P people = new P();
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
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro");
                }

            }
        }

    }
    public class P
    {
        public int Cod { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public DateTime Nascimento { get; set; }

        public bool ValidateAcess(List<P> People, string User, string pass)
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

    }
}
