namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("Part 1");
            Console.WriteLine();

            //Weight Conversion
            double weightInlbs = 0;
            while (weightInlbs <= 0)
            {
                Console.Write("Weight in Pounds (lbs): ");
                string input1 = Console.ReadLine();
                if (double.TryParse(input1, out double value1))
                {
                    if (value1 <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        weightInlbs = value1;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

            }
            double weightInkg = weightInlbs * 0.4535;
            double roundedWeightInkg = Math.Round(weightInkg, 2);
            Console.WriteLine($"Weight converted to Kilograms (kg): {roundedWeightInkg}");
            Console.WriteLine("==========================================");

            //Length Conversion
            double lengthInmi = 0;
            while (lengthInmi <= 0)
            {
                Console.Write("Length in Miles (mi): ");
                string input2 = Console.ReadLine();
                if (double.TryParse(input2, out double value2))
                {
                    if (value2 <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        lengthInmi = value2;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            double lengthInkm = lengthInmi * 1.609;
            double roundedLengthInkm = Math.Round(lengthInkm, 2);
            Console.WriteLine($"Length converted to Kilometers (km): {roundedLengthInkm}");
            Console.WriteLine("==========================================");

            //Temperature Conversion
            double tempInF = 0;
            while (tempInF <= 0)
            {
                Console.Write("Temperature in Fahrenheit (°F): ");
                string input3 = Console.ReadLine();
                if (double.TryParse(input3, out double value3))
                {
                    if (value3 <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        tempInF = value3;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            double tempInC = (tempInF - 32) * 5 / 9;
            double roundedTempInC = Math.Round(tempInC, 2);
            Console.WriteLine($"Temperature converted to Celsius (°C): {roundedTempInC}");
            Console.WriteLine("==========================================");

            //Average Age 
            double indexer = 1;
            List<double> ageList = new List<double>();
            while (indexer <= 10)
            {
                double newAge = 0;
                while (newAge <= 0)
                {
                    Console.Write("Age of Student {0}: ", indexer);
                    string input4 = Console.ReadLine();
                    if (double.TryParse(input4, out double value4))
                    {
                        if (value4 < 0)
                        {
                            Console.WriteLine("Invalid input.");
                        }
                        else
                        {
                            newAge = value4;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                ageList.Add(newAge);
                indexer += 1;
            }
            double averageAge = ageList.Sum() / (indexer - 1);
            double roundedAverageAge = Math.Round(averageAge, 1);
            Console.WriteLine("The average age of the students is {0}.", roundedAverageAge);
            Console.WriteLine("==========================================");

            //Multiline Story
            String[] names = ["Albert Van Gogh", "Trixie Mentia", "Ethan Lee", "Szean Tao", "Zhao Lee"];
            String[] kingdomNames = ["Arkdenm", "Manyger"];
            String[] equipmentNames = ["Demonheart Sword", "Floyen Armor"];
            String[] abilities = ["Boost", "Enhance"];

            //Story
            Console.WriteLine($@"A student named {names[0]} and his friend named {names[3]} were walking to school. When they were
crossing a pedestrian lane, a truck at full speed came and killed {names[0]} and {names[3]}. After a while, they 
woke up surrounded by twin knights named {names[2]} and {names[4]}. They were transported to the kingdom 
of {kingdomNames[0]}. A few days later, they were given {equipmentNames[0]} and {equipmentNames[1]} and they also 
found out that the twin knights, {names[2]} and {names[4]}, were the first knights of Duke Floyen. The twin knights
taught {names[0]} and {names[3]} abilities like {abilities[0]} and {abilities[1]}, which can be used in combat.
After months of training, {names[0]} and {names[3]} wanted to go to another kingdom named, {kingdomNames[1]}, where
{names[1]} was the ruler of the kingdom. They went and said their farewells to {names[2]} and {names[4]}. They started 
their travels to go to the kingdom of {kingdomNames[1]}, where they may encounter many problems and hindraces along the way.");
            Console.WriteLine();

            //Part 2
            Console.WriteLine("Part 2");
            Console.WriteLine();

            //Right Triangle
            int num = 0;
            while (num <= 0)
            {
                Console.Write("Input: ");
                string input5 = Console.ReadLine();
                if (int.TryParse(input5, out int value5))
                {
                    if (value5 <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        num = value5;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==========================================");

            //Summation
            int num2 = 0;
            while (num2 <= 0)
            {
                Console.Write("Input: ");
                string input6 = Console.ReadLine();
                if (int.TryParse(input6, out int value6))
                {
                    if (value6 <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        num2 = value6;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }   
            }
            int[] formula_list = new int[num2];
            for (int i = 0; i < num2; i++)
            {
                 formula_list[i] = i + 1;
            }
            Console.WriteLine("Formula: " + string.Join("+", formula_list));

            int sum = formula_list.Sum();
            Console.WriteLine("Summation: " + sum);
            Console.WriteLine("==========================================");

            // Inverse Triangle
            int num3 = 0;
            while (num3 <= 0)
            {
                Console.Write("Input: ");
                string input7 = Console.ReadLine();
                if (int.TryParse(input7, out int value7))
                {
                    if (value7 <= 0)
                    {
                      Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                         num3 = value7;
                         break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            for (int i = num3; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}