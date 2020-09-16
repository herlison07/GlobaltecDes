using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace People.Autentication.Models
{
    public class People
    {
        public int Cod { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public DateTime Nascimento { get; set; }

        public People()
        {
        }

        public People(int Cod, string Cpf, string Nome, string Uf, int d, int m, int a)
        {
            this.Cod = Cod;
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.Uf = Uf;
            this.Nascimento = new DateTime(a, m, d);
        }

        public static bool GetPeopleAcess(List<People> People, string User, string pass)
        {
            if((People.Find(x=>x.Nome == User && x.Cpf == pass))!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateAcess(List<People> People, string User, string pass)
        {
            if((People.Find(x=>x.Nome == User && x.Cpf == pass))!=null)
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
            return "\nCodigo: " + Cod + "\n" +
                   "Nome: " + Nome + "\n" +
                   "Cpf: " + Cpf + "\n" +
                   "Uf: " + Uf + "\n" +
                   "Nascimento: " + Nascimento.ToString("dd/MM/yyyy");
        }
    }
}