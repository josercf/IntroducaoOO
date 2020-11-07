using System.Collections.Generic;

namespace IntroducaoOO
{
    public class Pessoa
    {
        public Pessoa(string nome, string cPF, string rG)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
        }

        public string Nome { get; private set; }
        public string CPF { get; }
        public string RG { get; set; }
        public string Endereco { get; private set; }

        private List<string> _historicoEndereco = new List<string>();



        public void AtualizarNome(string novoNome)
        {

            if (novoNome == "")
                return;

            if (novoNome.Length < 2)
                return;

            Nome = novoNome;
        }


        //Devido a propriedade não possuir o set, só é permitido informar o CPF no construtuor.
        public void AtualizarCPF(string NovoCPF)
        {
            //CPF = NovoCPF;
        }

        public void AtualizaEndereco(string novoEndereco)
        {
            if (string.IsNullOrEmpty(novoEndereco))
                return;

            _historicoEndereco.Add(novoEndereco);

            Endereco = novoEndereco;
        }
    }
}
