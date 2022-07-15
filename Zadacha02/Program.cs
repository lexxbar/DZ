Console.WriteLine("Enter number 1:"); 
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 3:"); 
int c = Convert.ToInt32(Console.ReadLine());
int max;

if( a > b )
    max = a;
else
    max = b;
if( c > max )
    max = c;

Console.WriteLine("Max num:" + max);        