using System;

namespace miniinterface
{
    class Program
    {
        interface IItem
        {
            string nome { get; set; }
            int ouroValor { get; set; }

            void Equip();
            void Venda();

        }

        interface IDanificavel
        {
            int durabilidade { get; set; }
            void SofrerDano(int _quantidade);
            
        }

        interface IParteDaMissao
        {
            void Ligar();

        }

        class Espada : IItem, IDanificavel, IParteDaMissao
        {
            public string nome { get; set; }
            public int ouroValor { get; set; }
            public int durabilidade { get; set; }

            public Espada(string _nome)
            {
                nome = _nome;
                ouroValor = 100;
                durabilidade = 30;
            }

            public void Equip()
            {
                Console.WriteLine(nome + " equipado.");
            }

            public void Venda ()
            {
                Console.WriteLine(nome + " vendido por " + ouroValor + " dolares imaginarios!");
            }

            public void SofrerDano (int _dno)
            {
                durabilidade -= _dno;
                Console.WriteLine(nome + " danificado por " + _dno + ". E agora tem a durabilidade de " + durabilidade);
            }

            public void Ligar ()
            {
                Console.WriteLine (nome + " ligou.");
            }
        }

        class Machado : IItem, IDanificavel, IParteDaMissao
        {
            public string nome { get; set; }
            public int ouroValor { get; set; }
            public int durabilidade { get; set; }

            public Machado(string _nome)
            {
                nome = _nome;
                ouroValor = 70;
                durabilidade = 50;
            }

            public void Equip()
            {
                Console.WriteLine(nome + " equipado.");
            }

            public void Venda()
            {
                Console.WriteLine(nome + " vendido por " + ouroValor + " dolares imaginarios!");
            }

            public void SofrerDano(int _dno)
            {
                durabilidade -= _dno;
                Console.WriteLine(nome + " danificado por " + _dno + ". E agora tem a durabilidade de " + durabilidade);
            }

            public void Ligar()
            {
                Console.WriteLine(nome + " ligou. (isso é um machado).");
            }
        }

        static void Main(string[] args)
        {
            Espada espada = new Espada("Espada do Destino");
            espada.Equip();
            espada.SofrerDano(20);
            espada.Venda();
            

            Console.WriteLine();

            Machado machado = new Machado("Machado Furioso");
            machado.Equip();
            machado.SofrerDano(10);
            machado.Venda();

            Console.WriteLine();

            IItem[] inventario = new IItem[2];
            inventario[0] = espada;
            inventario[1] = machado;

            for (int i = 0; i < inventario.Length; i++)
            {
                IParteDaMissao missaoItem = inventario[i] as IParteDaMissao;
                
                if (missaoItem != null)
                {
                    missaoItem.Ligar();
                }
            }

            Console.ReadKey();

;       }
    }
}
