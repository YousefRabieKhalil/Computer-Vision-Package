using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlingClasses
{
    public abstract class StructureElement
    {
        /// <summary>
        /// The Length OF Structure ELement 
        /// </summary>
        public abstract int StructureSideLength
        {
            get;
        }
        /// <summary>
        /// The Structure Element Matrix
        /// </summary>
        public abstract int[,] StructureElemtnMatrix
        {
            get;
        }

        /// <summary>
        /// Getting The Matrix of The Structre Element
        /// </summary>
        /// <returns> The Structure Elemtn Matrix </returns>
        public abstract int[,] GetStructureElemntMatrix();
        /// <summary>
        /// Reintialize the STE Matrix
        /// </summary>
        /// <param name="NewMatrix"> The STE Matrix </param>
        public abstract void RedfineSTEmatrix(int[,] NewMatrix);
    }
}
