using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicisApp1.Materials
{
    internal abstract class Material
    {
        public int Size { get; set; }

        public int Weight { get; set; }

        public bool insideBox { get; set; }

        public Material(int size, int weight)
        {
            Size = size;
            Weight = weight;
            insideBox = false;
        }
    }
}
