using System;

class Fila
{
    private string[] elementos;
    private int inicio;
    private int fim;
    private int tamanho;

    public Fila(int capacidade)
    {
        elementos = new string[capacidade];
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

    public void Inserir(string valor)
    {
        if (!EstaCheia())
        {
            elementos[fim] = valor;
            fim = (fim + 1) % elementos.Length;
            tamanho++;
        }
    }

    public string Remover()
    {
        if (!EstaVazia())
        {
            string valor = elementos[inicio];
            inicio = (inicio + 1) % elementos.Length;
            tamanho--;
            return valor;
        }
        return null;
    }

    public int ObterTamanho()
    {
        return tamanho;
    }

    public void Listar()
    {
        for (int i = 0; i < tamanho; i++)
        {
            int index = (inicio + i) % elementos.Length;
            Console.WriteLine(elementos[index]);
        }
    }

    public string ObterPrimeiro()
    {
        if (!EstaVazia())
        {
            return elementos[inicio];
        }
        return null;
    }
}

class Programa
{
    static void Main()
    {
        Fila fila = new Fila(5);
        int opcao = 0;

        while (opcao != 6)
        {
            Console.WriteLine("Op:");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine(fila.ObterTamanho());
            }
            else if (opcao == 2)
            {
                string removido = fila.Remover();
                if (removido != null)
                {
                    Console.WriteLine(removido);
                }
            }
            else if (opcao == 3)
            {
                string id = Console.ReadLine();
                fila.Inserir(id);
            }
            else if (opcao == 4)
            {
                fila.Listar();
            }
            else if (opcao == 5)
            {
                string primeiro = fila.ObterPrimeiro();
                if (primeiro != null)
                {
                    Console.WriteLine(primeiro);
                }
            }
        }
    }
}
