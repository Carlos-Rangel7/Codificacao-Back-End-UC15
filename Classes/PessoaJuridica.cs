using System.Text.RegularExpressions;
using Back_End_ER02.Interfaces;
using Back_End_ER06.Classes;

namespace Back_End_ER02.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public string caminho { get; private set; } = "DataBase/PessoaJuridica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * 0.03f;

            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.05f;

            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento * 0.07f;

            }
            else
            {
                return rendimento * 0.09f;
            }
        }

        internal void ValidarCnpj()
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {// \ digito e / caractere
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14}) | (\d{2}. \d{3}. \d{3}/ \d{4}- \d{2}) $");

            if (retornoCnpjValido)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                }
            }

            string subStringCnpj18 = cnpj.Substring(11, 4);

            if (subStringCnpj18 == "0001")
            {
                return true;
            }
            return false;
        }

        public void Inserir(PessoaJuridica pj)
        {
            Utils.VerificarPastaArquivo(caminho);
            string[] pjValores = { $"{pj.nome},{pj.cnpj} ,{pj.razaoSocial}" };
            File.AppendAllLines(caminho, pjValores); //appendAllines inserir
        }

        public List<PessoaJuridica> LerArquivo()
        {

            List<PessoaJuridica> listPj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
              string[] atributos = cadaLinha.Split(",");

              PessoaJuridica CadaPj = new PessoaJuridica();
        
              CadaPj.nome = atributos[0];
              CadaPj.cnpj = atributos[1];
              CadaPj.razaoSocial = atributos[2];

              listPj.Add(CadaPj);
            }

            return listPj;

        }

    }
}