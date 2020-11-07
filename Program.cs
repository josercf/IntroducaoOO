using System;

namespace IntroducaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //A palavra new cria uma instancia do Objeto na mémória quando o programa rodar e passar por ela
            //No momento em que se cria a instância de classe, o método contstrutor é executado
            Monitor monitor = new Monitor("LG");
            //Quando a propriedade está ao lado esquerdo do sinal de igual, acontece a escrita do valor
            monitor.Cor = "azul";
            monitor.Ligar();
            monitor.Desligar();
            //Quando a propriedade está ao lado direito do sinal de igual, acontece a leitura do valor
            string marca = monitor.Marca;


            var pessoa1 = new Pessoa("João Carlos", "19100000000", "12456456");


            Console.WriteLine("Hello World!");
        }
    }
}
