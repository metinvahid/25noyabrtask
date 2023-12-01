namespace _25noyabr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Task1");
            Console.WriteLine("İki eded verilib");
            Console.WriteLine("Birinci ededi daxil edin");
            string input1 = Console.ReadLine();
            Console.WriteLine("2ci ededi daxil edin");
            string input2 = Console.ReadLine();
            int input1Num;
            int input2Num;

            while (!(int.TryParse(input1, out input1Num) && (int.TryParse(input2, out input2Num))))
            {
                Console.WriteLine("Sehvdi yeniden daxil edin");
                Console.WriteLine("1 ci ededi daxil edin");
                input1 = Console.ReadLine();
                Console.WriteLine("2 ci ededi daxil edin");
                input2 = Console.ReadLine();
            }
            int.TryParse(input1, out input1Num);
            int.TryParse(input2, out input2Num);

            int z = input1Num + input2Num;
            Console.WriteLine(z);
            if (z % 2 != 0)
            {
                Console.WriteLine("Cem tek ededdir");
            }
            else if (z == 0)
            {
                Console.WriteLine("cem 0 a beraberdir");
            }
            else
            {
                Console.WriteLine("cem cut eddedir");
            }

            Console.WriteLine(" "); Console.WriteLine(" ");

            //Task2
            Console.WriteLine("Task2");

            int[] numeral = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numeral.Length; i++)
            {

                if (numeral[i] % 2 == 0)
                {

                    Console.WriteLine(numeral[i]);


                }
            }
            Console.WriteLine(" "); Console.WriteLine(" ");

            //Task3
            Console.WriteLine("Task3");
            int sum = 0;
            for (int i = 0; i < numeral.Length; i++)
            {
                if (numeral[i] % 2 != 0)
                {
                    sum += numeral[i];
                }

            }
            Console.WriteLine(sum);

            Console.WriteLine(" "); Console.WriteLine(" ");


            //Task4
            Console.WriteLine("Task4");
            Console.Write("4 reqemli eded daxil edin ");

            string input3 = Console.ReadLine();

            if (input3.Length == 4 && int.TryParse(input3, out int num))
            {
                int digitSum = CalculateDigitSum(num);
                Console.WriteLine("Verilmis ededdeki reqemlerin cemi:");
                Console.WriteLine(digitSum);
            }
            else
            {
                Console.WriteLine("Xeta: Zehmet olmasa duzgun 4 reqemli eded daxil edin");
            }
        }
        static int CalculateDigitSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;

            Console.Write("");

            //TASK4.1
            Console.WriteLine("TASK4.1");
            string num1 = Console.ReadLine();
            if (num1.Length > 4 || num1.Length < 4)
            {
                Console.Write("Eded 4 reqemli deyil");
            }
            else
            {
                int sum1 = 0;
                int.TryParse(num1, out int number);
                while (number > 0)
                {
                    sum = sum + (number % 10);
                    number = number / 10;
                }
                Console.WriteLine(sum);
            }



            Console.WriteLine(" ");







            Console.WriteLine("Task5");

            Student students = new Student { Name = "Metin", Surname = "Vahid", Age = 19, Speciality = "Frontend developer", Gender = "Male", GroupNo = 419 };
            Student students2 = new Student { Name = "Vahid", Surname = "Metin", Age = 23, Speciality = "Backend developer", Gender = "Male", GroupNo = 60, };
            Student students3 = new Student { Name = "Leyla", Surname = "Hesenli", Age = 18, Speciality = "Gender Analitic", Gender = "Feamle", GroupNo = 222 };
            Student students4 = new Student { Name = "Nergiz", Surname = "Hebibova", Age = 17, Speciality = "Teacher", Gender = "Female", GroupNo = 14, };

            Student[] students1 = new Student[] { students, students2, students3, students4 };

            Console.WriteLine(students1[0].Name); Console.WriteLine(students1[0].Surname); Console.WriteLine(students1[0].Age); Console.WriteLine(students1[0].Speciality); Console.WriteLine(students1[0].Gender); Console.WriteLine(students1[0].GroupNo);
            Console.WriteLine(" ");
            Console.WriteLine(students1[1].Name); Console.WriteLine(students1[1].Surname); Console.WriteLine(students1[1].Age); Console.WriteLine(students1[1].Speciality); Console.WriteLine(students1[1].Gender); Console.WriteLine(students1[1].GroupNo);
            Console.WriteLine(" ");
            Console.WriteLine(students1[2].Name); Console.WriteLine(students1[2].Surname); Console.WriteLine(students1[2].Age); Console.WriteLine(students1[2].Speciality); Console.WriteLine(students1[2].Gender); Console.WriteLine(students1[2].GroupNo);
            Console.WriteLine(" ");
            Console.WriteLine(students1[3].Name); Console.WriteLine(students1[3].Surname); Console.WriteLine(students1[3].Age); Console.WriteLine(students1[3].Speciality); Console.WriteLine(students1[3].Gender); Console.WriteLine(students1[3].GroupNo);











            Console.ReadKey();
        }
        public class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public string Speciality { get; set; }
            public int GroupNo { get; set; }
            public string Gender { get; set; }
        }


    }
}

