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

                Console.WriteLine("deseja fazer mais alguma operação ? s = sim | n = não");
                op2 = Console.ReadLine();
                Console.Clear();
                menuprincipal();
            } while (op2 == "s");

            
        }
        static void menuprincipal()
        {
            Console.WriteLine(FiggleFonts.Standard.Render(" Bem - vindo  ao "));
            Console.WriteLine(FiggleFonts.Standard.Render("Menu Principal"));
            Console.WriteLine(FiggleFonts.Standard.Render("Gestão de Livros"));
        }
        static void menu()
        {
            int id;
            No<string> L1 = null;
            No<string> L2 = null;
            string caminho = @"D:\caminho.txt";
            //string caminho2 = @"C:\caminho2\caminho2.txt";
            Lista l = new Lista();
            Console.Write(" Escolha uma das opções a cima :  ");
            int i = 0;
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":

                    L1 = new No<string>();
                    L2 = new No<string>();
                    //l.CarregaArquivo(L1, caminho);
                    //string isbn1, tipo1, titulo1, autor1, editora1;
                    int test;
                    bool result = false;
                    while (result == false)
                    {

                       Console.Clear();
                        menuprincipal();
                        Console.WriteLine("Menu inserir\n");
                            Console.WriteLine("Introduza o ISBN !");
                            L1.Isbn = Console.ReadLine();
                        Console.Clear();
                        
                        result = int.TryParse(L1.Isbn, out test);
                        if (result == false)
                            while (result == false)
                            {
                                menuprincipal();
                                Console.WriteLine("Menu inserir\n");
                                Console.WriteLine("Erro: ISBN invalido, volte a introduzir o ISBN");
                                L1.Isbn = Console.ReadLine();
                                result = int.TryParse(L1.Isbn, out test);
                                Console.Clear();
                            }
                    }
                    menuprincipal();
                    Console.WriteLine("Menu inserir\n");
                    Console.WriteLine("Introduza o tipo !");
                        L1.Tipo1 = Console.ReadLine();
                    Console.Clear();
                    menuprincipal();
                    Console.WriteLine("Menu inserir\n");
                    Console.WriteLine("Introduza o titulo !");
                        L1.Titulo1 = Console.ReadLine();
                    Console.Clear();
                    menuprincipal();
                    Console.WriteLine("Menu inserir\n");
                    Console.WriteLine("Introduza o/a autor(a) !");
                        L1.autor1 = Console.ReadLine();
                    Console.Clear();
                    menuprincipal();
                    Console.WriteLine("Menu inserir\n");
                    Console.WriteLine("Introduza o/a editor(a) !");
                        L1.editora1 = Console.ReadLine();
                    Console.Clear();
                    menuprincipal();
                    //l.insere(isbn1, tipo1, titulo1, autor1, editora1);
                    // l.exibir();
                            l.Salva(L1, caminho);
                    
                        //l.Imprime(L1);
                        Console.WriteLine();
                        Console.WriteLine("Salvo com sucesso !");
                        i++;

                    //Console.Clear();
                    //Console.WriteLine(FiggleFonts.Standard.Render(" Bem - vindo  ao "));
                    //Console.WriteLine(FiggleFonts.Standard.Render("Menu Principal"));
                    //Console.WriteLine(FiggleFonts.Standard.Render("Gestão de Livros"));

                    //string f = "| 1 - inserir \n| 2 - remover \n| 3 - Listar\n  ";
                    ////Console.SetCursorPosition((Console.WindowWidth - r.Length) / 2, Console.CursorTop);
                    //Console.WriteLine(f);
                    break;
                case "2":
                    Console.Clear();
                    menuprincipal();
                    string n;
                    int test1;
                    Console.WriteLine("Menu remover\n");
                    l.ler(L1, caminho);
                    int numeroLinhas = System.IO.File.ReadAllLines(@"C:\caminho2\caminho.txt").Length;
                    if (numeroLinhas == 0)
                    {
                        Console.WriteLine("Erro: Não existe registro para eliminar");
                        break;
                    }
                    result = false;
                    Console.Write("Qual registro deseja apagar ? Se não dejesar apagar carregue na tecla n :");
                    n = Console.ReadLine();
                    result = int.TryParse(n, out test1);

                    if (numeroLinhas-1 < test1 || numeroLinhas-1 > test1)
                    {
                        result = false;
                    }
                    
                        

                    if (n == "n")
                    {
                        result = true;
                        Console.Clear();
                        menuprincipal();
                        break;
                    }
                    
                    while (result == false)
                    {
                        Console.Clear();
                        menuprincipal();
                        Console.WriteLine("Menu remover\n");
                        l.ler(L1, caminho);
                        Console.Write("Introduza um numero válido. Se não dejesar apagar carregue na tecla n :");
                        n = Console.ReadLine();
                        if (n == "n")
                        {
                            result = true;
                            Console.Clear();
                            menuprincipal();
                            break;
                        }
                        else
                        result = int.TryParse(n, out test1);

                        if (numeroLinhas - 1 < test1 || numeroLinhas - 1 > test1)
                        {
                            n = "no";
                        }
                        result = int.TryParse(n, out id);
                    }
                    if (n == "n")
                        break;
                    result = int.TryParse(n, out id);
                    for (i = 0; i <= id; i++)
                    {
                        l.removed(i);
                    }
                    Console.WriteLine("removido com sucesso !");
                    break;
                case "3":
                    Console.Clear();
                    menuprincipal();
                    Console.WriteLine("Menu Lista\n");
                    l.ler(L1,caminho);
                    break;
                case "4":
                    Console.Clear();
                    menuprincipal();
                    Console.WriteLine("Menu numero de registros\n");
                    l.contar_numerosderegistros();

                    break;
            }

        }
       
   
    }
}
