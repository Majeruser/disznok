using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs;

public class FileBeolvasa
{
    public static List<disznokClass> ReadFile(string fileName)
    {
		 List<disznokClass> Disznolist = new List<disznokClass>();
		try
		{
			foreach (string line in File.ReadLines(fileName, Encoding.UTF8).Skip(1))
			{
				Disznolist.Add(new disznokClass(line.Replace('.', ',').Split(";")));

			}

		}
		catch (Exception error)
		{
            Console.WriteLine(error.Message);
		}
		return Disznolist;
    }
}
