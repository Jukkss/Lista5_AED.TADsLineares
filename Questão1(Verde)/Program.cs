using System;

namespace Lista05_AED.TADLinear
{
    internal class Filatempos
    {
        static void Main(string[] args)
        {
            Filatempos FiladeTempos = new Filatempos(100);
            int op;

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        double tempo = double.Parse(Console.ReadLine());
                        FiladeTempos.InserirInicio(tempo);
                        break;

                    case 2:
                        tempo = double.Parse(Console.ReadLine());
                        FiladeTempos.InserirFinal(tempo);
                        break;

                    case 3:
                        tempo = double.Parse(Console.ReadLine());
                        int pos = int.Parse(Console.ReadLine());
                        FiladeTempos.Inserir(tempo, pos);
                        break;

                    case 4:
                        FiladeTempos.RemoverInicio();
                        break;

                    case 5:
                        FiladeTempos.RemoverFinal();
                        break;

                    case 6:
                        pos = int.Parse(Console.ReadLine());
                        FiladeTempos.RemoverPosicao(pos);
                        break;

                    case 7:
                        tempo = double.Parse(Console.ReadLine());
                        FiladeTempos.RemoverItem(tempo);
                        break;

                    case 8:
                        tempo = double.Parse(Console.ReadLine());
                        int count = FiladeTempos.Contar(tempo);
                        Console.WriteLine(count);
                        break;

                    case 9:
                        FiladeTempos.Mostrar();
                        break;

                    case 10:
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (op != 10);
        }

        private double[] tempos;
        private int n;

        public Filatempos(int tam)
        {
            this.tempos = new double[tam];
            this.n = 0;
        }

        public void InserirInicio(double tempo)
        {
            if (n >= tempos.Length)
                return;

            for (int i = n; i > 0; i--)
                tempos[i] = tempos[i - 1];

            tempos[0] = tempo;
            n++;
        }

        public void InserirFinal(double tempo)
        {
            if (n >= tempos.Length)
                return;

            tempos[n] = tempo;
            n++;
        }

        public void Inserir(double tempo, int pos)
        {
            if (n >= tempos.Length || pos < 0 || pos > n)
                return;

            for (int i = n; i > pos; i--)
                tempos[i] = tempos[i - 1];

            tempos[pos] = tempo;
            n++;
        }

        public void RemoverFinal()
        {
            if (n <= 0)
                return;

            n--;
            Console.WriteLine(tempos[n]);
        }

        public void RemoverInicio()
        {
            if (n <= 0)
                return;

            Console.WriteLine(tempos[0]);

            for (int i = 0; i < n - 1; i++)
                tempos[i] = tempos[i + 1];

            n--;
        }

        public void RemoverPosicao(int pos)
        {
            if (pos < 0 || pos >= n)
                return;

            Console.WriteLine(tempos[pos]);

            for (int i = pos; i < n - 1; i++)
                tempos[i] = tempos[i + 1];

            n--;
        }

        public void RemoverItem(double tempo)
        {
            for (int i = 0; i < n; i++)
            {
                if (tempos[i] == tempo)
                {
                    for (int j = i; j < n - 1; j++)
                        tempos[j] = tempos[j + 1];

                    n--;
                    break;
                }
            }
        }

        public int Contar(double tempo)
        {
            int ctt = 0;
            for (int i = 0; i < n; i++)
            {
                if (tempos[i] == tempo)
                    ctt++;
            }
            return ctt;
        }

        public void Mostrar()
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(tempos[i]);
        }
    }
}

