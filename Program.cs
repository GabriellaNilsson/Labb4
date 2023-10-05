namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gabriella Nilsson
            // NET23

            // CASE 1
            // Problem: Det saknades ett kolontecken i Console.WriteLine i if-statement. Det andra problemet var att det stod elseif istället för else if.  
            // Lösning: Lade till ett kolontecken på rad 16 och ändrade elseif till else if på rad 18. 

            //int number = 2;

            //if (number > 3)
            //{
            //    Console.WriteLine("Talet är större än tre");
            //}
            //else if (number < 3)
            //{
            //    Console.WriteLine("Talet är mindre än tre");
            //}


            // CASE 2
            // Problem: Eftersom det börjar på 0 och inte 1, så skriver det ut till 99 istället för 100. 
            // Lösning: Lade till en siffra, alltså ändrade "i < 100" till "i < 101"

            //for (int i = 1; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // CASE 3
            // Problem:Den tredje och sista iterationen saknar något som gör att det ökar varje gång loopen körs. 
            // Lösning: I den nestlade loopen, ändrade den sista iterationen i till i++ och j till j++. 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}


            // CASE 4  
            // Problem: Det saknas data som skrivs ut i consolen. 
            // Lösning: Lade till "j" i consolen i for loopen så att den printar siffrorna och " " efter, för att göra utskriften snyggare. 

            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }

            //    Console.WriteLine();
            //    i++;
            //}


            // CASE 5 
            // Problem: Det skrevs ut "Two" i consolen eftersom det saknades ett break under case 1. då break avslutar switch-statement och hoppar ut ur det. Utan ett break tillhörande case 1, kommer koden köras vidare till case 2.   
            // Lösning: Lade till break under case 1. 

            //int i = 1;

            //switch (i)
            //{
            //    case 1:
            //        break;
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}


            // CASE 6
            // Problem: " = " är en tilldelningsoperator, alltså tilldela värde till en variabel. " == " = är en jämförelseoperator. Om det står " i = 5 " som villkor i en if-sats tilldelar det ett nytt värde till variabeln "i" i villkoret, vilket inte är logiskt. Det korrekta är då istället att använda " == ", då if-satsen kollar om i är 5 och kommer då returnera om det är true eller false (bool-värde). 
            // Lösning: Ändrade "if (i = 5)" till "if (i == 5)".

            //int i = 10;

            //if (i == 5)
            //{
            //    Console.WriteLine("i är 5");
            //}




        }
    }
}