int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    Console.WriteLine("Введите {0}-е число массива", i + 1);
                    mas[i]= int.Parse(Console.ReadLine());
                }
            return mas;
            }
void PrintArray(int[] mmm)
            {
                       for (int i=0;i<mmm.Length;i++) 
                {
                    if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
                    else Console.WriteLine($"{mmm[i]}");
                }
            }

int  positive(int [ ] mmm)
{
    int checker =  0;
    for (int i = 0;i<mmm.Length;i++) if (mmm[i]>0) checker+=1;
    return checker;
}
Console.WriteLine("размерность массива ?");
int n = int.Parse(Console.ReadLine());
int[] array = FillArray(n);
PrintArray(array);
Console.WriteLine("число положительных элементов - "+positive(array));
