using System;
using System.IO;
class Program
{
    static void Main()
    {
        Console.WriteLine("organizar? (s) (n)");
        string ativar = Console.ReadLine();
        if (ativar == "s")
        {
            string pastaOrigem = @"D:\Downloads";
            if (Directory.Exists(pastaOrigem))
            {
                Console.WriteLine("a pasta existe");
                string[] arquivos = Directory.GetFiles(pastaOrigem);
                List<string> lista = new List<string>();
                foreach (string arquivo in arquivos)
                {
                    string diretorioArquivo = Path.Combine(pastaOrigem, arquivo);
                    string extensao = Path.GetExtension(arquivo);
                    if (extensao == ".jpeg" || extensao == ".jpg" || extensao == ".png" || extensao == ".gif")
                    {
                        File.Move(diretorioArquivo, "C:\\Users\\eduar\\Pictures");
                    }
                    else if (extensao == ".pdf" || extensao == ".docx" || extensao == ".txt" || extensao == ".pptx")
                    {
                        File.Move(diretorioArquivo, "C:\\Users\\eduar\\Documents");
                    }
                    else if (extensao == ".exe")
                    {
                        File.Delete(diretorioArquivo);
                    }
                    else if (extensao == ".py" || extensao == ".cs" || extensao == ".sql" || extensao == ".html" || extensao == ".json" || extensao == ".css")
                    {
                        File.Move(diretorioArquivo, "D:\\pastaCode");
                    }
                    else
                    {
                        lista.Add(arquivo);
                    }
                }
                Console.WriteLine("Arquivos não organizados:\n" + string.Join("\n", lista) + "\nDeseja excluir os arquivos? (s) (n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    Console.WriteLine("revisar individualmente? (s) (n)  obs.:Senão, será tudo apagado");
                    string question = Console.ReadLine();
                    if (question == "s")
                    {
                        for (int i = lista.Count - 1; i >= 0; i--)
                        {
                            string arquivo = lista[i];
                            Console.WriteLine(arquivo + "\napagar? (s) (n)" + "\n");
                            string pergunta = Console.ReadLine();
                            if (pergunta == "s")
                            {
                                string diretorioLista = Path.Combine(pastaOrigem, arquivo);
                                File.Delete(diretorioLista);
                                lista.RemoveAt(i);
                            }
                            else
                            {
                                lista.RemoveAt(i);
                            }
                        }
                    }
                    else
                    {
                        foreach (string arquivo in lista)
                        {
                            string diretorioLista = Path.Combine(pastaOrigem, arquivo);
                            File.Delete(diretorioLista);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Arquivos organizados.");
                }
            }
            else
            {
                Console.WriteLine("A pasta não existe");
            }
        }
    }
}