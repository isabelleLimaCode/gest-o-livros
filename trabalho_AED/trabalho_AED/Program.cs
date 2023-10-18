using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
using System.IO;

namespace trabalho_AED
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Standard.Render(" Bem - vindo  ao "));
            Console.WriteLine(FiggleFonts.Standard.Render("Menu Principal"));
            Console.WriteLine(FiggleFonts.Standard.Render("Gestão de Livros"));

            string r = "| 1 - inserir \n| 2 - remover \n| 3 - Listar\n| 4 - quantidade de registros\n  ";
            string op2;
            do
            {
              
                //Console.SetCursorPosition((Console.WindowWidth - r.Length) / 2, Console.CursorTop);
                Console.WriteLine(r);
                menu();
                //Console.Clear();

                Console.WriteLine("deseja fazer mais alguma operação ?");
                op2 = Console.ReadLine();
            } while (op2 == "s");
            
        }
        static void menu()
        {
            //int i = 0;
            int id;
            No<string> L1 = null;
            No<string> L2 = null;
            string caminho = @"C:\caminho2\caminho.txt";
            //string caminho2 = @"C:\caminho2\caminho2.txt";
            Lista l = new Lista();
            Console.Write(" Escolha uma das opções a cima :  ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":

                    L1 = new No<string>();
                    L2 = new No<string>();
                    //l.CarregaArquivo(L1, caminho);
                    //string isbn1, tipo1, titulo1, autor1, editora1;
                    Console.WriteLine("introduza o isbn !");
                        L1.Isbn = Console.ReadLine();
                        Console.WriteLine("introduza o tipo !");
                        L1.Tipo1= Console.ReadLine();
                        Console.WriteLine("introduza o titulo !");
                        L1.Titulo1= Console.ReadLine();
                        Console.WriteLine("introduza o autor !");
                        L1.autor1 = Console.ReadLine();
                        Console.WriteLine("introduza a editora !");
                        L1.editora1 = Console.ReadLine();
                          //  l.insere(isbn1, tipo1, titulo1, autor1, editora1);
                            // l.exibir();
                            l.Salva(L1, caminho);
                            //l.Imprime(L1);
                        Console.WriteLine();
                        Console.WriteLine("Salvo com sucesso !");
                    //string resposta;
                    //do
                    //{

                    //    Console.WriteLine("deseja fazer mais algum registro?");
                    //    resposta = Console.ReadLine();
                    //    Console.WriteLine("introduza o isbn !");
                    //    L1.Isbn = Console.ReadLine();
                    //    Console.WriteLine("introduza o tipo !");
                    //    L1.Tipo1 = Console.ReadLine();
                    //    Console.WriteLine("introduza o titulo !");
                    //    L1.Titulo1 = Console.ReadLine();
                    //    Console.WriteLine("introduza o autor !");
                    //    L1.autor1 = Console.ReadLine();
                    //    Console.WriteLine("introduza a editora !");
                    //    L1.editora1 = Console.ReadLine();
                    //    l.Salva(L1, caminho);
                    //} while (resposta == "s");
                    //menu();

                    break;
                case "2":
                    l.ler(L1, caminho);
                    Console.Write("Quantidade de registros que deseja apagar :");
                    id = Convert.ToInt32(Console.ReadLine());
                    l.removed(id);
                    Console.WriteLine("removido com sucesso !");
                    break;
                case "3":
                    l.ler(L1,caminho);
                    break;
                case "4":
                    l.contar_numerosderegistros(); 

                    break;
            }

        }
       
   
    }
}
