using System;

namespace CalculationMethods_L3_WPF;

public static class GaussianMethod
{
    // Метод Гаусса для решения системы линейных уравнений
    public static string Gauss(double[,] system)
    {
        var n = 4; //разрядность системы
        var result = new double[n];
            
        // Прямой ход метода Гаусса
        for (var i = 0; i < n-1; i++)
        {
            for (var j = i+1; j < n; j++)
            {
                var ratio = system[j, i] / system[i, i];
                    
                for (var k = i; k < n; k++)
                {
                    system[j, k] -= ratio * system[i, k];
                }
            }
        }
            
        // Обратный ход метода Гаусса
        for (var i = n - 1; i >= 0; i--)
        {
            result[i] = system[i, n] / system[i, i];

            for (var j = i - 1; j >= 0; j--)
            {
                system[j, n] -= system[j, i] * result[i];
                system[j, i] = 0;
            }
        }

        var output = "";
        for (var i = 0; i < n; i++)
        {
            output += "x" + (i + 1) + " = " + result[i] + "\n";
        }
        return output;
    }
}
