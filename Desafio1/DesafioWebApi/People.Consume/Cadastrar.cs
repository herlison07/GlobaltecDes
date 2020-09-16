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
                client.BaseAddress = new Uri("http://localhost:62216/api/person");
                Autentication.Models.People people = new Autentication.Models.People();
                people.Cod = 0;
                people.Nome = TbNome.Text;
                people.Cpf = TbCpf.Text;
                people.Uf = CbUf.SelectedText;
                people.Nascimento = DtpNascimento.Value;

                var resp = await client.PostAsJsonAsync("", people);


            }
        }
    }
}
