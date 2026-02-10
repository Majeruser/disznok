namespace program.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<disznokClass> Pigs = FileBeolvasa.ReadFile("disznok2.csv");

            disznokClass legidosebb = Pigs.First();
            disznokClass legnehezebb = Pigs.First();

            foreach (disznokClass diszno in Pigs)
            {
                if (diszno.age > legidosebb.age)
                {
                    legidosebb = diszno;
                }
                if(diszno.weight > legnehezebb.weight)
                {
                    legnehezebb = diszno;
                }
            }
            Console.WriteLine($"A legidoseeb diszno neve: {legidosebb.name}");
            Console.WriteLine($"A legnehezebb diszno neve: {legnehezebb.name}");
            Console.WriteLine("-----------------------------");
            disznokClass leghosszab = Pigs.First();

            foreach (disznokClass pig in Pigs)
            {
                if (pig.name.Count() > leghosszab.name.Count())
                    leghosszab = pig;

            }
            Console.WriteLine(leghosszab.name);
            Console.WriteLine("-----------------------------");

            int num = 0;
            int num2 = 0;
            foreach(disznokClass pig in Pigs)
            {
                if(pig.gender == "kan")
                {
                    Console.WriteLine(pig);
                    num2 += 1;
                }
                if(pig.gender == "koca")
                {
                    num+=1;
                }
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"ennyi hölgy Disznó van:{num}");
            Console.WriteLine($"ennyi úr Disznó van:{num2}");
            Console.WriteLine("---------------------------------------");
            double atlag = 0;
            int count = 0;

            double Natlag = 0;
            int Ncount = 0;
            foreach (disznokClass pig in Pigs)
            {
                if (pig.gender == "kan")
                {
                    atlag += pig.weight;
                    count++;
                }
                if (pig.gender == "koca")
                {
                    Natlag += pig.age;
                    Ncount += 1;
                }
            }
            Console.WriteLine(atlag/count);
            Console.WriteLine(Natlag / Ncount);


            double bums = 0;
            int nums = 0;
            foreach (disznokClass pig in Pigs)
            {
                if(pig.name.Count()/2 == 0)
                {
                    pig.Feed();
                }
                if(pig.age >= 2)
                {
                    bums += pig.weight;
                    nums++;
                }
            }
            Console.WriteLine(bums / nums);
            foreach (disznokClass pig in Pigs)
            {
                if( pig.weight > bums / nums)
                {
                    Console.WriteLine(pig);
                }
            }



                Console.ReadKey();
        }
    }
}
