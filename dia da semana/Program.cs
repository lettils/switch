class Program
{
    static void Main()
    {
        

        Console.WriteLine("Digite um número de 1 a 7");
        int informacao = Convert.ToInt32(Console.ReadLine());

        switch (informacao)
        {
            case 1:
                Console.WriteLine("Segunda-feira");
                break;
            case 2:
                Console.WriteLine("Terça-feira");
                break;
            case 3:
                Console.WriteLine("Quarta-feira");
                break;
            case 4:
                Console.WriteLine("Quinta-feira");
                break;
            case 5:
                Console.WriteLine("Sexta-feira");
                break;
            case 6:
                Console.WriteLine("sabado");
                break;

                case 7:
                Console.WriteLine("domingo");
                break;



        }



    }
}