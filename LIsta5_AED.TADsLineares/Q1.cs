//Lita5_AED - TADsLineares - Questão1(SemVerde)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05_AED.TADLinear
{
    internal class Filatempos
    {
        static void Main(string[] args)
        {
            Filatempos FiladeTempos = new Filatempos(100);
            Console.WriteLine("Op:");
            int op = int.Parse(Console.ReadLine());
            do
            {
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
                        FiladeTempos.Contar(tempo);
                        break;
                    case 9:
                        FiladeTempos.Mostrar();
                        break;
                    case 10:
                        return;
                }
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());
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
            /* if (n >= tempos.Length)
            {
                throw new Exception("Erro! Lista cheia");
            }*/

            for (int i = n; i > 0; i--)
            {
                tempos[i] = tempos[i - 1];
            }
            tempos[0] = tempo;
            /* Console.WriteLine($"Tempo inserido {tempo}");*/
            n++;
        }
        public void InserirFinal(double tempo)
        {
            /* if (n >= tempos.Length)
            {
                throw new Exception("Erro! Lista cheia");
            }*/

            tempos[n] = tempo;
            /* Console.WriteLine($"Tempo inserido {tempo}");*/
            n++;
        }
        public void Inserir(double tempo, int pos)
        {
            /*if ( n >= tempos.Length) { throw new Exception("Erro! Lista cheia"); }*/
            for (int i = n; i > pos; i--)
            {
                tempos[i] = tempos[i - 1];
            }

            tempos[pos] = tempo;
            n++;
        }
        public void RemoverFinal()
        {
            /*if (tempos.Length < 1)
            {
                throw new Exception("Erro! Lista sem componentes");
            }*/

            double temp = tempos[n];
            n--;
            Console.WriteLine(temp);
        }
        public void RemoverInicio()
        {
            /*if (tempos.Length < 1)
            {
                throw new Exception("Erro! Lista sem componentes");
            }*/

            double temp = tempos[0];
            n--;
            Console.WriteLine(temp);

            for (int i = 0; i < n; i++)
            {
                tempos[i] = tempos[i + 1];
            }
        }
        public void RemoverItem(double tempo)
        {
            /*if (tempos.Length < 1)
            {
                throw new Exception("Erro! Lista sem componentes");
            }*/

            for (int i = 0; i < n; i++)
            {
                if (tempos[i] == tempo)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        tempos[j] = tempos[j + 1];
                    }
                }
                n--;
            }
        }
        public void RemoverPosicao(int pos)
        {
            /*if (tempos.Length < 1)
            {
                throw new Exception("Erro! Lista sem componentes");
            }*/

            double temp = tempos[pos];
            Console.WriteLine(temp);
            n--;

            for (int i = 0; i < n; i++)
            {
                tempos[i] = tempos[i + 1];
            }

        }
        public int Contar(double tempo)
        {
            /*if (tempos.Length < 1)
            {
                throw new Exception("Erro! Lista sem componentes");
            }*/

            int ctt = 0;
            for (int i = 0; i < n; i++)
            {
                if (tempos[i] == tempo)
                {
                    ctt++;
                }
            }
            return ctt;
        }
        public void Mostrar()
        {
            /*if (tempos.Length < 1)
           {
               throw new Exception("Erro! Lista sem componentes");
           }*/

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tempos[i]);
            }
        }
    }
}
