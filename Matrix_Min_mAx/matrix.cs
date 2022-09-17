Console.WriteLine("колличество столбцов?");
int Wide =  int.Parse(Console.ReadLine());

Console.WriteLine("колличество строк?");
int Up =  int.Parse(Console.ReadLine());

int[,] FillArray(int Up,int Wide)
            {
            int[,] mas = new int[Up,Wide];

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        Console.Write("введите  "+"["+i+", "+j+"]-й элемент: ");
                        mas[i,j]= int.Parse(Console.ReadLine());
                    }
        
                }
            return mas;
            }
void PrintArray(int[,] mas)
            {

            for (int i=0;i<Up;i++) 
                {
                    int j = 0;
                    while ( j!=(Wide-1)) 
                    {
                        Console.Write(mas[i,j]+", ");
                        j++;
                    }
                    Console.WriteLine(mas[i,j]);
                }
            Console.WriteLine();
            }
void  MiniMAx(int[,] mas)
{
    int Ind_i_Max=0;
    int Ind_j_Max=0;
    int Ind_i_Min=0;
    int Ind_j_Min=0;

    for (int i=0;i<Up;i++) 
                {
                   for (int j=0;j<Wide;j++) 
                    {
                    if (mas[i,j]>mas[Ind_i_Max,Ind_j_Max]) 
                        {
                            Ind_i_Max=i;
                            Ind_j_Max=j;
                        }
                    else if (mas[i,j]<mas[Ind_i_Min,Ind_j_Min])
                    {
                        Ind_i_Min=i;
                        Ind_j_Min=j;
                    }
                    }
                }
    Console.WriteLine($"максимальный элемент - {mas[Ind_i_Max,Ind_j_Max]} c индексом {Ind_i_Max}, {Ind_j_Max}");
    Console.WriteLine($"максимальный элемент - {mas[Ind_i_Min,Ind_j_Min]} c индексом {Ind_i_Min}, {Ind_j_Min}");
}


int [,] rezult = new int[Up,Wide];
rezult = FillArray(Up,Wide);
PrintArray(rezult);
MiniMAx(rezult);
