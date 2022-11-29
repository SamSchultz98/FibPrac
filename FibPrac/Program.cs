


using System.Runtime.InteropServices;
using System.Security.Principal;










Fib(3, 3000);





static int Fib(int i)
{

    while (i < 1000)
    {
        int k = i;
        int tot = i + k;
        Console.WriteLine(tot);
        k = tot + 1;
        i = tot;
    }
    Console.WriteLine("Fib Done");
}

