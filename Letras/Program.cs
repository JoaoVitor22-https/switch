class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma letra de A ate E: ");
        char informacao = Convert.ToChar(Console.ReadLine());


        switch (informacao)
        {

            case 'A':
                Console.WriteLine("Excelente");
                break;

            case 'B':
                Console.WriteLine("Bom");
                break;

            case 'C':
                Console.WriteLine("Regular");
                break;

            case 'D':
                Console.WriteLine("Ruim");
                break;

            case 'E':
                Console.WriteLine("Pessimo");
                break;

            default:
                Console.WriteLine("Letra não encontrada");
                break;

        }
    }
}