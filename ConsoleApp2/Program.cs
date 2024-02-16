using System.Security.Claims;

int select = 1;

do
{
    Console.Clear();
    switch (select)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 --->Calculator<--- 
    Exit    
");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
    Calculator
--->Exit<---
");
            Console.ForegroundColor = ConsoleColor.White;
            break;

    }

    ConsoleKeyInfo info = Console.ReadKey();
    if (info.Key == ConsoleKey.UpArrow || info.Key == ConsoleKey.W)
    {
        if (select == 1) select = 2;
        else select--;
    }
    else if (info.Key == ConsoleKey.DownArrow || info.Key == ConsoleKey.S)
    {
        if (select == 2) select = 1;
        else select++;
    }
    else if (info.Key == ConsoleKey.Enter)
    {
        if (select == 1)
        {

            Console.Write("Enter Num1: ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Num2: ");

            int num2 = int.Parse(Console.ReadLine());
                int secim = 1;
            do
            {

                Console.Clear();

                switch (secim)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("---> + <---");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--- - ---");
                        Console.WriteLine("--- / ---");
                        Console.WriteLine("--- * ---");
                        break;
                    case 2:
                        Console.WriteLine("--- + ---");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("---> - <---");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--- / ---");
                        Console.WriteLine("--- * ---");
                        break;
                    case 3:
                        Console.WriteLine("--- + ---");
                        Console.WriteLine("--- - ---");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("---> / <---");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--- * ---");
                        break;
                    case 4:
                        Console.WriteLine("--- + ---");
                        Console.WriteLine("--- - ---");
                        Console.WriteLine("--- / ---");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("---> * <---");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;



                }
                var infoo = Console.ReadKey();

                if (infoo.Key == ConsoleKey.UpArrow || infoo.Key == ConsoleKey.W)
                {
                    if (secim == 1) secim = 4;
                    else secim--;
                }
                else if (infoo.Key == ConsoleKey.DownArrow || infoo.Key == ConsoleKey.S)
                {
                    if (secim == 4) secim = 1;
                    else secim++;
                }
                else if (infoo.Key == ConsoleKey.Enter) 
                {
                    Console.Clear();
                if(secim == 1) 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(@$" 
                   ANSWER                 
              |      |      |

              |      |      |
             


            --->{num1} + {num2} = {num1 + num2}<---"); 
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                else if(secim == 2) 
                    {
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine(@$" 
                   ANSWER                 
              |      |      |

              |      |      |
             


            --->{num1} - {num2} = {num1 - num2}<---");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                else if (secim == 3) 
                    {
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine(@$" 
                   ANSWER                 
              |      |      |

              |      |      |
             


            --->{num1} / {num2} = {num1 / num2}<---");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else if (secim == 4) 
                    {
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.WriteLine(@$" 
                   ANSWER                 
              |      |      |

              |      |      |
             


            --->{num1} * {num2} = {num1 * num2}<---");
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    Thread.Sleep(2500);
                }
            }
            while (true);
        }
        else if (select == 2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                @"
                       SOS      SOS      SOS

                       SOS    GOODBYE    SOS

                       SOS      SOS      SOS ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        break;
    }

}
while (true);