using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs;

public class disznokClass
{
    public string name { get; set; }
    public string gender { get; set; }
    public double weight { get; set; }
    public int age { get; set; }
    public disznokClass(string[] data)
    {
        this.name = data[0].Trim(' ');
        this.gender = data[1].Trim(' ');
        this.weight = double.Parse(data[2]);
        this.age = int.Parse(data[3]);
    }
    public override string ToString()
    {
        return $"{name} - {gender} - {weight} - {age}";
    }
    public string Rename( string newName)
    {
        name = newName;
        return $"Az új neve:{newName}";
    }
    public double Feed()
    {
        weight = weight* 1.01;
        return weight;
    }


}
