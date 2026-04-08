using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string Select(IEnumerable<string> population, IEnumerable<double> fitnesses)
    {
        var rng = new Random().NextDouble();
        var pArr = population.ToArray();
        var fArr = fitnesses.ToArray();
        for (int i = 0; i < fArr.Length; ++i)
        {
            if (fArr[i] > rng)
            {
                return pArr[i];
            }
        }
        
        return "";
    }
}
