string [] Triangular (Double arg1, Double arg2, Double arg3)
{
    string [] Stats = new string [7];
    Stats [0] = "not a triangular";
    if (arg1 < arg2+arg3 && arg2 < arg1+arg3 && arg3 < arg1+arg2) 
     {
        Stats [0] = "это треугольник";
        Stats [1] = "без равных сторон";
        Stats [2] = Convert.ToString(arg1+arg2+arg3);
        Stats [3] = Convert.ToString(Math.Round ((Math.Acos(  (arg2*arg2+arg3*arg3-arg1*arg1)/(2*arg2*arg3)  )/Math.PI*180),4));
        Stats [4] = Convert.ToString(Math.Round ((Math.Acos((arg1*arg1+arg3*arg3-arg2*arg2)/(2*arg1*arg3) )/Math.PI*180),4));
        Stats [5] = Convert.ToString(Math.Round((Math.Acos((arg2*arg2+arg1*arg1-arg3*arg3)/(2*arg2*arg1) )/Math.PI*180),4));
        Stats [6] = Convert.ToString(Math.Round(Math.Sqrt(( ((arg1+arg2+arg3))/2) * ((arg1+arg2+arg3)/2-arg1) *
                                            (((arg1+arg2+arg3)/2)-arg2) * (((arg1+arg2+arg3)/2)-arg3) ),4));
        if (arg1==arg2 ||  arg1==arg3 || arg2==arg3) Stats [1] = "он равнобедренный";
        if (arg1-arg2+arg3==arg1) Stats[1] = "он равносторонний";
        if (Stats[3]=="90" ||  Stats[4]=="90"  || Stats[5]=="90") Stats [1] += " и при этом прямоугольный";
     }
    return Stats;
}


Console.WriteLine ("введи стороны предполагаемого треугольника");
Double arg1 = Convert.ToDouble (Console.ReadLine());
Double arg2 = Convert.ToDouble (Console.ReadLine());
Double arg3 = Convert.ToDouble (Console.ReadLine());
string[] result = new string [7];
result = Triangular(arg1, arg2, arg3);
if (arg1 < arg2+arg3 && arg2 < arg1+arg3 && arg3 < arg1+arg2) Console.WriteLine ($"{result[0]} , {result[1]} с углами {result[3]} , {result[4]} , {result[5]} , с периметром {result[2]} и площадью {result[6]}");
else Console.WriteLine ("это не треугольник");
