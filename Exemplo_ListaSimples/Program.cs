using Exemplo_ListaSimples;

internal class Program
{
    private static void Main(string[] args)
    {
        ListItem list = new ListItem();
        Item item;
        Item i;
        int numero;
        string identificador;
        int esc;
        
        do
        {
            Console.WriteLine("1- inserir item");
            Console.WriteLine("2- Mostrar lista");
            Console.WriteLine("3- Procurar pelo identificador");
            Console.WriteLine("4- Sair");
            Console.WriteLine("Escolha: ");
            esc =int.Parse(Console.ReadLine());

            switch (esc)
            {
                case 1:
                    Console.WriteLine("Digite o valor: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o identificador: ");
                    identificador = Console.ReadLine();
                    item = new(numero, identificador);
                    list.Insert(item);
                    Console.WriteLine("Item inserido com sucesso");
                    break;

                case 2:
                    list.Print();
                    break;

                case 3:
                    Console.WriteLine("Pesquisar pelo identificador: ");
                    i = list.Find(Console.ReadLine());
                    if (i != null)
                    {
                        Console.WriteLine(i.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Este identificador nao exite");
                    }
                    break;

                case 4:
                    Console.WriteLine("saindo...");
                    break;

                default:
                    Console.WriteLine("operacao nao exite");
                    break;
            }
            
        } while (esc!=4);
        
    }
}