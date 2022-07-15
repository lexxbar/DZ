Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;

while (result <= n)
{
   if (result % 2 == 0)
       Console.Write ( result + " " );
   result = result + 1;    
}