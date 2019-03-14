using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

public class KnapsackAlgorithm
{
    public static double KnapSack(int capacity, int[] size, double[] fee, int count)
    {
        double[,] K = new double[count + 1, capacity + 1];
        
        for (int i = 0; i <= count; ++i)
        {
            for (int w = 0; w <= capacity; ++w)
            {
                if (i == 0 || w == 0){
                    K[i, w] = 0;
                }
                else if (size[i - 1] <= w)
                {
                    K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - size[i - 1]], K[i - 1, w]);

                }
                else{
                    K[i, w] = K[i - 1, w];

                }
                
            }
            
        }
        return K[count, capacity];
        
    }
    public static void Main()
    {
        double[] fee = { 0.0887, 0.1856, 0.2307, 0.1522, 0.0532, 0.0250, 0.1409, 0.2541, 0.1147, 0.2660, 0.2933, 0.0686};
        for (int y=0; y < fee.Length; y++)
        {
            fee[y] += 12.5;
            
        }
        int[] size = { 57247, 98732, 134928, 77275, 29240, 15440, 70820, 139603, 63718, 143807, 190457, 40572};
        int capacity = 10000000;
        
        double result = KnapSack(capacity, size, fee, fee.Length);
        Console.WriteLine(result);
        }
    }