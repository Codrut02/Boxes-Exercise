using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicisApp1.Materials;

namespace PublicisApp1.Boxes
{
    internal abstract class Box
    {
        public int Size { get; set; }
        public int AvailableSize { get; set; }

        public int Weight { get; set; }
        public int AvailableWeight { get; set; }

        public Box(int size, int weight)
        {
            Size = size;
            AvailableSize = size;
            Weight = weight;
            AvailableWeight = weight;
        }
    }
}
