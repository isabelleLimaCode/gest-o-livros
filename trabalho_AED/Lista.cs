using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trabalho_AED
{
    class Lista
    {
        No<string> _cabeca, _cauda;
        private int size = 0;

        public void insere(string isbn, string tipo, string titulo, string autor, string editora)
        {
            // cria o no ( instanciar)

            No<string> novono = new No<string>();
            novono.Isbn = isbn;
            novono.Tipo1 = tipo;
            novono.Titulo1 = titulo;
            novono.autor1 = autor;
            novono.editora1 = editora;
            // verifficar se é o primeiro elemento 
            if (_cabeca == null)
            {
                _cabeca = novono;// cabeça aponta para o novo nó 

            }
            else
            {
                _cauda.proximo = novono;


            }
            _cauda = novono;
        }
        public void exibir()
        {
            if (_cabeca != null)
            {
                No<string> temp = _cabeca;
                while (temp != null)
                {
                    string r = "| Isbn | Tipo | Titulo | autor | editora |";
                    Console.WriteLine(r);
                    Console.Write(temp.Isbn + " ");
                    Console.Write(temp.Tipo1 + " ");
                    Console.Write(temp.Titulo1 + " ");
                    Console.Write(temp.autor1 + " ");
                    Console.Write(temp.editora1 + " ");
                    temp = temp.proximo;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nLista vazia");
            }
        }
        //public void automovel(int matricula ,string nome , int hora )
        //{
        //}
        public int Count
        {  //propriedade Count,só para consulta (read only)
            get { return size; }
        }
        public bool IsEmpty() { return size == 0; }

        public void CarregaArquivo(No<string> n, string caminho)
        {
            using (StreamReader sr = new StreamReader(caminho))
            {
                No<string> p = n;
                string s = sr.ReadLine();
                string a = sr.ReadLine();
                string b = sr.ReadLine();
                string c = sr.ReadLine();
                string d = sr.ReadLine();
                p.Isbn = s;
                p.Tipo1 = a;
                p.Titulo1 = b;
                p.autor1 = c;
                p.editora1 = d;
                while (!sr.EndOfStream)
                {
                    p.proximo = new No<string>();
                    s = sr.ReadLine();
                    p = p.proximo;
                    p.Isbn = s;
                    p.Tipo1 = a;
                    p.Titulo1 = b;
                    p.autor1 = c;
                    p.editora1 = d;
                }
            }

        }
        public void Salva(No<String> novo, string caminho)
        {
            using (StreamWriter sw = new StreamWriter(caminho, true))
            {
                No<String> corrente = novo;
                while (corrente != null)
                {
                    sw.Write("| Isbn: "+corrente.Isbn);
                    sw.Write(" | Tipo: "+corrente.Tipo1);
                    sw.Write(" | Titulo: "+corrente.Titulo1);
                    sw.Write(" | Autor(a): "+corrente.autor1);
                    sw.Write(" | Editor(a): "+corrente.editora1);
                    sw.WriteLine("");
                    corrente = corrente.proximo;
                    sw.Write("");
                }

            }
        }
        public void Imprime(No<string> n)
        {
            if (n == null)
                return;

            Console.WriteLine(n.Isbn + " ");
            Console.WriteLine(n.Tipo1 + " ");
            Console.WriteLine(n.Titulo1 + " ");
            Console.WriteLine(n.autor1 + " ");
            Console.WriteLine(n.editora1 + " ");


            n = n.proximo;

            Imprime(n);
        }
        public void ler(No<String> novo, string caminho)
        {

            using (StreamReader reader = new StreamReader(caminho))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    
                    string linha;
                    linha = reader.ReadLine();
                    Console.WriteLine("Nº "+i+ " " + linha+"\n");
                    i++;

                }

            }

        }
        public void loadUsers( No<String>  novo,  string caminho)
        {

            using (System.IO.StreamReader file = new System.IO.StreamReader(File.Open(caminho, System.IO.FileMode.OpenOrCreate)))
            {
                while (!file.EndOfStream)
                {
                    string linha;
                    linha = file.ReadLine();
                }
            }



        }
        public void removed(int id)
        {
            
            var file = new List<string>(System.IO.File.ReadAllLines(@"C:\caminho2\caminho.txt"));
            file.RemoveAt(id);
            File.WriteAllLines(@"C:\caminho2\caminho.txt", file.ToArray());
        
        }
        public void contar_numerosderegistros()
        {
            int  numeroLinhas = System.IO.File.ReadAllLines(@"C:\caminho2\caminho.txt").Length;
            Console.WriteLine("O numeros de registros é {0} ", numeroLinhas);

        }

    }
}