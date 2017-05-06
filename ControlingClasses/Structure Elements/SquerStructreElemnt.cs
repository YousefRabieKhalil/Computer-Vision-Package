using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlingClasses.Structure_Elements
{
    class SquerStructreElemnt : StructureElement
    {
        public override int[,] StructureElemtnMatrix
        {
            get;
        }

        public override int StructureSideLength
        {
            get;
        }

        public override int[,] GetStructureElemntMatrix()
        {
            throw new NotImplementedException();
        }

        public override void RedfineSTEmatrix(int[,] NewMatrix)
        {
            
        }
    }
}
