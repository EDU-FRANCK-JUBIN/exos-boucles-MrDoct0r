using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication4
{
    public class Boucle
    {
        public void MultipleOf2()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int j = 0;
            while (j <= 20)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }
        }

        public void Sum()
        {
            Console.WriteLine("Veuillez saisir un entier : ");
            int i = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 0; j <= i; j++)
            {
                sum += j;
            }

            Console.WriteLine($"Le résultat est : {sum}");
        }

        public void Average()
        {
            Console.WriteLine("Veuillez saisir un premier entier : ");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un deuxième entier : ");
            int i2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un troisième entier : ");
            int i3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un quatrième entier : ");
            int i4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un cinquième entier : ");
            int i5 = Int32.Parse(Console.ReadLine());

            int sum = i1 + i2 + i3 + i4 + i5;
            Console.WriteLine($"La moyenne est : {sum / 5}");
        }

        public static void CalculSommeEntier(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("Le premier entier doit être inférieur au second");
            }
            else
            {
                int sum = 0;
                for (int i = x; i <= y; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"Le résultat est : {sum}");
            }
        }

        public static void CalculMoyenne(List<double> list)
        {
            double sum = 0;
            list.ForEach(x => sum += x);

            double moyenne = sum / list.Count;
            Console.WriteLine($"La moyenne est : {moyenne}");
        }

        public void constructList()
        {
            List<int> multipleOf3 = new List<int>();
            List<int> multipleOf5 = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    multipleOf3.Add(i);
                }

                if (i % 5 == 0)
                {
                    multipleOf5.Add(i);
                }
            }

            int sum = multipleOf3.Intersect(multipleOf5).Sum();
            Console.WriteLine($"Le résultat est : {sum}");
        }
    }
}