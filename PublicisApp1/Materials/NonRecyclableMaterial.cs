using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicisApp1.Materials
{
    internal class NonRecyclableMaterial : Material
    {
        public NonRecyclableMaterial(int size, int weight) : base(size, weight)
        {
        }
    }
}
