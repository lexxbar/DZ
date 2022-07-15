Console.WriteLine("Enter num 1 :");  
int a = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Enter num 2 :");  
int b = Convert.ToInt32(Console.ReadLine ());

if ( a < b )
{
    Console.WriteLine ("Min:" + a);
    Console.WriteLine ("Max:" + b);  
}
else
{
    Console.WriteLine ("Min:" + b);
    Console.WriteLine ("Max:" + a);
}
