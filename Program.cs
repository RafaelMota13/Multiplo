int n1, n2, resto; 

Console.WriteLine("\n---Múltiplo---");

Console.Write("\nDigite um número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Avaliar se é múltiplo de: ");
n2 = Convert.ToInt32(Console.ReadLine());

resto = n1 % n2;


if (resto ==0)
    {

      Console.ForegroundColor = ConsoleColor.DarkGreen;

       Console.WriteLine($"\n{n1} é múltiplo {n2}\n");

      Console.ResetColor();

    }
else
    {
    
      Console.ForegroundColor = ConsoleColor.Red;

      Console.WriteLine($"\n{n1} não é múltiplo {n2}\n");

      Console.ResetColor();
      
    }
