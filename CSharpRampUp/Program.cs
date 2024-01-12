namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Weight Conversion
            Console.WriteLine("Part 1");
            Console.WriteLine();
            Console.Write("Weight in Pounds (lbs): ");
            double weightInlbs = Convert.ToDouble(Console.ReadLine());
            double weightInkg = weightInlbs * 0.4535;
            double roundedWeightInkg = Math.Round(weightInkg, 2);
            Console.WriteLine($"Weight converted to Kilograms (kg): {roundedWeightInkg}");
            Console.WriteLine("==========================================");

            //Length Conversion
            Console.Write("Length in Miles (mi): ");
            double lengthInmi = Convert.ToDouble(Console.ReadLine());
            double lengthInkm = lengthInmi * 1.6093;
            double roundedLengthInkm = Math.Round(lengthInkm, 2);
            Console.WriteLine($"Length converted to Kilometers (km): {roundedLengthInkm}");
            Console.WriteLine("==========================================");

            //Temperature Conversion
            Console.Write("Temperature in Fahrenheit (°F): ");
            double tempInF = Convert.ToDouble(Console.ReadLine());
            double tempInC = (tempInF - 32) * 5 / 9;
            double roundedTempInC = Math.Round(tempInC, 2);
            Console.WriteLine($"Temperature converted to Celsius (°C): {roundedTempInC}");
            Console.WriteLine("==========================================");

            //Average Age 
            int indexer = 1;
            List<int> ageList = new List<int>();
            while (indexer <= 10)
            {
                Console.Write("Age of Student {0}:", indexer);
                int newAge = Convert.ToInt32(Console.ReadLine());
                ageList.Add(newAge);
                indexer += 1;
            }
            int averageAge = ageList.Sum() / indexer;
            Console.WriteLine("The average age of the students is {0}.", averageAge);
            Console.WriteLine("==========================================");

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
            //Right Triangle
            Console.WriteLine("Part 2");
            Console.WriteLine();
            int num = 0;
            while (num <= 0)
            {
                Console.Write("Input: ");
                num = Convert.ToInt16(Console.ReadLine());
                if (num <= 0)
                {
                    Console.WriteLine("Invalid input.");
                }
                else
                {
                    break;
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
            Console.Write("Input: ");
            int num2 = 0;
            while (num2 <= 0)
            {
                Console.Write("Input: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 <= 0)
                {
                    Console.WriteLine("Invalid input.");
                }
                else
                {
                    break;
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
            Console.Write("Input: ");
            int num3 = 0;
            while (num3 <= 0)
            {
                Console.Write("Input: ");
                num3 = Convert.ToInt16(Console.ReadLine());
                if (num3 <= 0)
                {
                    Console.WriteLine("Invalid input.");
                }
                else
                {
                    break;
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
