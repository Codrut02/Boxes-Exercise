using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicisApp1.Materials;

namespace PublicisApp1.Boxes
{
    internal class BoxNonRecyclable : Box
    {
        public List<NonRecyclableMaterial> Materials { get; set; }

        public BoxNonRecyclable(int size, int weight) : base(size, weight)
        {
            Materials = new();
        }

        public void AddMaterial(NonRecyclableMaterial material)
        {
            Materials.Add(material);
            AvailableSize -= material.Size;
            AvailableWeight -= material.Weight;
        }
    }
}
