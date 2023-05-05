using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicisApp1.Materials;

namespace PublicisApp1.Boxes
{
    internal class BoxRecyclable : Box
    {
        public List<RecyclableMaterial> Materials { get; set; }

        public BoxRecyclable(int size, int weight) : base(size, weight)
        {
            Materials = new();
        }

        public void AddMaterial(RecyclableMaterial material)
        {
            Materials.Add(material);
            AvailableSize -= material.Size;
            AvailableWeight -= material.Weight;
        }
    }
}
