namespace Bootcamp.Common.Models
{
    public class Pessoa
    {
        /*Construtor - Deve ter o mesmo nome da classe e não possui retorno
            Podemos ter quantos construtores quisermos
        */

        public Pessoa() //Construtor padrão
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        //Inverso do construtor - 'out' é o parâmetro de saída
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }


        // Para gerar uma propriedade mais rapido, inicie digitando 'prop'
        /*   Validações Get e Set  */
        private string _nome;/*Campo - Nao tem Get e Set*/ /*Encapsulamento*/
        private int _idade;


        public string Nome /*Propriedade - Tem Get e Set*/
        {
            /*Flexibilização de Get e Set*/


            get => _nome.ToUpper(); /* Body expression */

            set
            {
                /* value é o argumento que está sendo recebido na propriedade nome*/
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Pode-se ter so o Get ou só o Set (Este com lógica inclusa)

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }


        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}, e tenho {Idade} anos.");
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}, \n e tenho {Idade} anos.");
        }
    }
}