using System;

class Arquivo
{
    public string nome;
    public int paginas;

    public Arquivo(string nome, int paginas)
    {
        this.nome = nome;
        this.paginas = paginas;
    }

    public override string ToString()
    {
        return nome + " " + paginas;
    }
}

class Fila
{
    private Arquivo[] fila;
    private int inicio;
    private int fim;
    private int total;

    public Fila(int tamanho)
    {
        fila = new Arquivo[tamanho];
        inicio = 0;
        fim = 0;
        total = 0;
    }

    public void Inserir(Arquivo a)
    {
        if (total < fila.Length)
        {
            fila[fim] = a;
            fim = (fim + 1) % fila.Length;
            total++;
        }
    }

    public Arquivo Retirar()
    {
        if (total > 0)
        {
            Arquivo a = fila[inicio];
            inicio = (inicio + 1) % fila.Length;
            total--;
            return a;
        }
        return null;
    }

    public void Listar()
    {
        for (int i = 0; i < total; i++)
        {
            int index = (inicio + i) % fila.Length;
            Console.WriteLine(fila[index].ToString());
        }
    }

    public bool Vazia()
    {
        return total == 0;
    }
}

class Teste
{
    static void Main()
    {
        Fila fila = new Fila(100);
        int op = 0;

        while (op != 4)
        {
            Console.WriteLine("Op:");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                string nome = Console.ReadLine();
                int paginas = int.Parse(Console.ReadLine());
                Arquivo arq = new Arquivo(nome, paginas);
                fila.Inserir(arq);
            }
            else if (op == 2)
            {
                Arquivo a = fila.Retirar();
                if (a != null)
                {
                    Console.WriteLine(a.nome);
                }
            }
            else if (op == 3)
            {
                fila.Listar();
            }
        }
    }
}


