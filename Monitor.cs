namespace IntroducaoOO
{
    //Uma classe possui atributos, propriedades e métodos
    //Um objeto possui Estado e comportamento

    //Classe                     | Objeto
    //Atributos (privados)       | Estado
    //Propriedades (públicas)    | Estado
    //Métodos                    | Comportamento

    class Monitor
    {

        //Método construtor
        //ele é executado sempre que se cria uma instancia da Classe.
        //Em C# e Java, o metódo construtor possui o mesmo nome da classe
        //Ele não retorna valores, nem mesmo void
        public Monitor(string marca)
        {
            this.Marca = marca;
        }





        //Tipos de Dados
        //int -> Representa números inteiros
        //char -> representam caracter (a, B, 1, X)
        //bool -> Representa verdadeito ou falso (true ou false);
        //string -> representa uma cadeia de caracteres, ex.: Seu nome, Samsung, Panasonic;
        //float, double, decimal -> representam números que possuem casas decimais
        //...
        //Monitor -> Representa um objetos que reproduz imagens quando ligado à um dispositivo que as emite


        /*******************************************************/
        //Atributos: São privados, ou seja, somente visiveis no escopo da Classe
        //Propriedades: Podem ser publicas, ou seja, estarem visíveis fora do escopo da classe;


        //Anatomia da propriedade:
        //Modificador de acesso: private(utilizado somente dento da classe), public (utilizado por outras classes)
        //Tipo da propriedade: int, char, string, bool, entre outros ou uma classe.
        //Nome: Representa a ação a ser executada, geralmente é utilizado um substantivo
        //Get; representa a leitura do valor e o Set que representa a escrita;
        public string Marca { get; private set; }//Samsung, LG, Panasonic
        public float Tamanho { get; set; } //9, 12,18, 19,22, 27.5, 32
        public string Cor { get; set; } //azul, preto, branco....
        public string Resolucao { get; set; } //1080 X 960

        private bool _estaLigado;



        //Anatomia do método:
        //Modificador de acesso: private(utilizado somente dento da classe), public (utilizado por outras classes)
        //Tipo de retorno: void (quando não retorna nada), int, char, string, bool, entre outros ou uma classe.
        //Nome: Representa a ação a ser executada, geralmente é utilizado um método no infinitivo
        //Argumentos: O método pode ou não receber argumentos para executar ações,int, char, string, bool, entre outros ou uma classe. 
        //
        public void Ligar()
        {
            this._estaLigado = true;
        }


        public void Desligar()
            => _estaLigado = false;


        public void AlterarMarca(string novaMarca)
        {
            Marca = novaMarca;
        }

    }
}
