using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicisApp1.Boxes;
using PublicisApp1.Materials;

namespace PublicisApp1.Utils
{
    internal static class Utils
    {
        static public List<Material> GenerateListMaterials(int numberOfMaterials)
        {
            List<Material> list = new();
            Random rnd = new();

            for (int i = 0; i < numberOfMaterials; i++)
            {
                int size = rnd.Next(1, 10);
                int weight = rnd.Next(1, 10);
                int recyclableOrNot = rnd.Next(0, 2);
                if(recyclableOrNot == 1)
                    list.Add(new RecyclableMaterial(size, weight));
                else
                    list.Add(new NonRecyclableMaterial(size, weight));
            }

            return list;
        }

        static public void AddMaterialsToBoxes(List<Material> list, BoxRecyclable recyclableBox, BoxNonRecyclable nonRecyclableBox)
        {
            foreach (Material material in list)
            {
                if (material.GetType() == typeof(RecyclableMaterial))
                {
                    if (recyclableBox.AvailableSize >= material.Size && recyclableBox.AvailableWeight >= material.Weight)
                    {
                        recyclableBox.AddMaterial((RecyclableMaterial)material);
                        material.insideBox = true;
                    }
                }
                else
                {
                    if (nonRecyclableBox.AvailableSize >= material.Size && nonRecyclableBox.AvailableWeight >= material.Weight)
                    {
                        nonRecyclableBox.AddMaterial((NonRecyclableMaterial)material);
                        material.insideBox = true;
                    }
                }
            }
        }
    }
}
