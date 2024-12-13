namespace aula_19_encapsulamento
{
    public class Produto
    {
        // private string _nome; // convenção de nomenclatura do C#: _nome
        // Propredade autoimplementada
        public string Nome { get; set;}
        private double _preco;
        private int _quantidade;

        // Construtor padrão

        public Produto()
        {

        }

        // Construtor com 2 argumentos
        public Produto(string nome, double preco)
        {
            // _nome = nome;
            Nome = nome;
            _preco = preco;
        }

        // Reutilizano construtor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        // Encapsulamento, que é Get(retornar) e Set(alterar) de atribuos privados
        // public string GetNome()
        // {
        //     return _nome;
        // }

        // public void SetNome(string nome)
        // {
        //     if (nome != null && nome.Length > 1)
        //     {
        //         _nome = nome;
        //     } 
        // }

        //  Agora vou utilizar propriedade do C# para fazer o Get e Set
        // public string Nome
        // {
        //     get 
        //     {
        //         return _nome; 
        //     }
        //     set
        //     {
        //         // o value é uma palavra reservada do C# que pega o valor que está sendo passado
        //         if(value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }

        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double preco)
        // {
        //     if( preco > 0 && preco < 100000)
        //     {
        //        _preco = preco;
        //     }
        // }

        public double Preco{
            get{
                return _preco;
            }
            set
            {
                if( value > 0 && value < 100000)
            {
               _preco = value;
            }
            }
        }

        public double GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        // Função adicionar quantidade em estoque
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        // Função remover quantidade em estoque
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        // Função calcular valor total em estoque
        public double ValorTotalEmEstoque()
        {
            // get {return _preco * _quantidade; }
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return Nome + " , $ " + _preco.ToString("F2") + ", " + _quantidade + " unidades, Total: $"+ ValorTotalEmEstoque().ToString("F2");
        }
    }
}