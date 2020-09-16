using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumirWebApi
{
    public partial class Cadastrar : Form
    {
        AccessLink uri = new AccessLink();
        public Cadastrar()
        {
            InitializeComponent();
        }

        private async void BtnCadastrar_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri.uri + "api/people");
                People people = new People();
                people.Cod = 0;
                people.Cpf = TbCpf.Text;
                people.Nome = TbNome.Text;
                people.Uf = CbUf.SelectedItem.ToString();
                people.Nascimento = DtpNascimento.Value;
                try
                {
                    var resp = await client.PostAsJsonAsync(uri.uri + "api/people", people);
                    string ret = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show(people.ToString(), "Sucesso no cadastro");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar", ex.Message);
                }
            }
        }
    }
    public class People
    {
        public int Cod { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public DateTime Nascimento { get; set; }


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
