using System;

class BitwiseOperator
{
    static void Main()
    {
        var x = Convert.ToInt32("1010", 2);
        Console.WriteLine(x);
        var y = Convert.ToInt32("0110", 2);
        Console.WriteLine(y);

        var and = x & y;
        Console.WriteLine(and);
        Console.WriteLine($"{and} : {Convert.ToString(and, 2)}");

        var or = x | y;
        Console.WriteLine($"{or} : {Convert.ToString(or, 2)}");

        var xor = x ^ y;
        Console.WriteLine($"{xor} : {Convert.ToString(xor, 2)}");

        var not = ~x; //2의 보수법에 따라서 1010 + 1 그리고 부호를 -로 -1011 => -11
        Console.WriteLine($"{not} : {Convert.ToString(not, 2)}");
    }
}