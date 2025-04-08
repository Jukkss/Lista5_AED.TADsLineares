using System;

class Pilha
{
    private char[] elementos;
    private int topo;

    public Pilha(int tamanho)
    {
        elementos = new char[tamanho];
        topo = 0;
    }

    public void Empilhar(char c)
    {
        if (topo < elementos.Length)
        {
            elementos[topo] = c;
            topo = topo + 1;
        }
    }

    public char Desempilhar()
    {
        if (topo > 0)
        {
            topo = topo - 1;
            return elementos[topo];
        }
        return '\0';
    }

    public int ObterTamanho()
    {
        return topo;
    }

    public bool Vazia()
    {
        if (topo == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Verificador
{
    static void Main()
    {
        string entrada = Console.ReadLine();

        Pilha pilha = new Pilha(100);
        bool correta = true;

        int i = 0;
        while (i < entrada.Length)
        {
            char c = entrada[i];

            if (c == '(' || c == '[')
            {
                pilha.Empilhar(c);
            }
            else if (c == ')' || c == ']')
            {
                if (pilha.Vazia())
                {
                    correta = false;
                    break;
                }

                char topo = pilha.Desempilhar();

                if (c == ')' && topo != '(')
                {
                    correta = false;
                    break;
                }
                else if (c == ']' && topo != '[')
                {
                    correta = false;
                    break;
                }
            }

            i = i + 1;
        }

        if (!pilha.Vazia())
        {
            correta = false;
        }

        if (correta == true)
        {
            Console.WriteLine("correta");
        }
        else
        {
            Console.WriteLine("errada");
        }
    }
}