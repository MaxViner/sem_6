Console.WriteLine("задайте уравнение двух прямых вида у=bx+k");

Double[] array = new Double[6];

    Console.WriteLine("ВВедите b1");
    array[0] = double.Parse(Console.ReadLine());
    Console.WriteLine("ВВедите k1");
    array[1]  = double.Parse(Console.ReadLine());
    Console.WriteLine("ВВедите b2");
    array[2]  = double.Parse(Console.ReadLine());
    Console.WriteLine("ВВедите k2");
    array[3]  = double.Parse(Console.ReadLine());
    array[4] = (array[2]-array[0])/(array[1]-array[3]);
    array[5] = array[1]*array[4]+array[0];
 
Console.WriteLine($"координаты точки пересечения прямых y = {array[1]}*x + {array[0]}  и  y = {array[3]}*x + {array[2]} :");
Console.WriteLine("("+array[4]+";"+array[5]+")");
