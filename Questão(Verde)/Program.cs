using System;

class Arquivo
{
    private string nome;
    private int paginas;

    public Arquivo(string nome, int paginas)
    {
        this.nome = nome;
        this.paginas = paginas;
    }

    public string ObterNome()
    {
        return nome;
    }

    public int ObterPaginas()
    {
        return paginas;
    }

    public string Mostrar()
    {
        return nome + " " + paginas;
    }
}

class Fila
{
    private Arquivo[] elementos;
    private int inicio;
    private int fim;
    private int tamanho;

    public Fila(int capacidade)
    {
        elementos = new Arquivo[capacidade];
        inicio = 0;
        fim = 0;
        tamanho = 0;
    }

    public bool EstaVazia()
    {
        return tamanho == 0;
    }

    public bool EstaCheia()
    {
        return tamanho == elementos.Length;
    }

    public bool Inserir(Arquivo arquivo)
    {
        if (!EstaCheia())
        {
            elementos[fim] = arquivo;
            fim = (fim + 1) % elementos.Length;
            tamanho++;
            return true;
        }
        else
        {
            Console.WriteLine("Fila cheia!");
            return false;
        }
    }

    public Arquivo Remover()
    {
        if (!EstaVazia())
        {
            Arquivo removido = elementos[inicio];
            inicio = (inicio + 1) % elementos.Length;
            tamanho--;
            return removido;
        }
        else
        {
            return null;
        }
    }

    public void Listar()
    {
        if (EstaVazia())
        {
            Console.WriteLine("Fila vazia");
            return;
        }

        int i = inicio;
        int cont = 0;

        while (cont < tamanho)
        {
            Console.WriteLine(elementos[i].Mostrar());
            i = (i + 1) % elementos.Length;
            cont++;
        }
    }
}

class Teste
{
    static void Main()
    {
        Fila fila = new Fila(100);
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("Op:");
            string entrada = Console.ReadLine();
            opcao = int.Parse(entrada);

            if (opcao == 1)
            {
                string nome = Console.ReadLine();
                int paginas = int.Parse(Console.ReadLine());
                Arquivo novo = new Arquivo(nome, paginas);
                fila.Inserir(novo);
            }
            else if (opcao == 2)
            {
                Arquivo arquivo = fila.Remover();
                if (arquivo != null)
                {
                    Console.WriteLine(arquivo.ObterNome());
                }
                else
                {
                    Console.WriteLine("Fila vazia");
                }
            }
            else if (opcao == 3)
            {
                fila.Listar();
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Encerrando...");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
