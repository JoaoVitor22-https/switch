class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um numero de 1 a 7: ");
        int informacao = Convert.ToInt32(Console.ReadLine());


        switch (informacao)
        {

            case 1:
                Console.WriteLine("Domingo");
            break;
                
            case 2:
                Console.WriteLine("Segunda");
            break;

            case 3:
                Console.WriteLine("Terça");
            break;

            case 4:
                Console.WriteLine("Quarta");
            break;

            case 5:
                Console.WriteLine("Quinta");
            break;

            case 6:
                Console.WriteLine("Sexta");
            break;

            case 7:
                Console.WriteLine("Sabado");
            break;

            default:
                Console.WriteLine("Valor não encontrado");
            break;

        }
    }
}