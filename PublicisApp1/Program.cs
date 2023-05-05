using PublicisApp1.Boxes;
using PublicisApp1.Materials;
using PublicisApp1.Utils;

namespace PublicisApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while(true) 
            {
                Random rnd = new();

                int size = rnd.Next(10, 100);
                int weight = rnd.Next(10, 100);
                BoxRecyclable recyclableBox = new(size, weight);

                size = rnd.Next(10, 100);
                weight = rnd.Next(10, 100);
                BoxNonRecyclable nonRecyclableBox = new(size, weight);

                int numberOfMaterials = rnd.Next(10, 60);

                Console.WriteLine(" ----------------------------------------------------------------------------- ");
                Console.WriteLine(" Recyclable Box : Size = " + recyclableBox.Size + " Weight = " + recyclableBox.Weight);
                Console.WriteLine(" Non Recyclable Box : Size = " + nonRecyclableBox.Size + " Weight = " + nonRecyclableBox.Weight + "\n\n");

                List<Material> list = Utils.Utils.GenerateListMaterials(numberOfMaterials);

                Utils.Utils.AddMaterialsToBoxes(list, recyclableBox, nonRecyclableBox);

                Console.WriteLine(" Number of materials generated : " + numberOfMaterials);
                Console.WriteLine(" List of materials (Green - it's in the recyclable box / Yellow - in the other one / Gray - neither one) \n");

                foreach(Material material in list)
                {
                    if (material.insideBox && material.GetType() == typeof(NonRecyclableMaterial))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (material.insideBox && material.GetType() == typeof(RecyclableMaterial))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.WriteLine(material.GetType().Name + " Size " + material.Size + " Weight " + material.Weight);

                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine("\n\n Recyclable Box : Available Size = " + recyclableBox.AvailableSize + " Available Weight = " + recyclableBox.AvailableWeight);  
                Console.WriteLine(" Non Recyclable Box : Available Size = " + nonRecyclableBox.AvailableSize + " Available Weight = " + nonRecyclableBox.AvailableWeight);
                Console.WriteLine(" ----------------------------------------------------------------------------- ");

                Console.Write(" Do you want to restart with newly generated values (y/n) : ");
                string restart = Console.ReadLine();
                if (restart != "y")
                {
                    Console.WriteLine("Bye !");
                    break;
                }
            }
        }
    }
}