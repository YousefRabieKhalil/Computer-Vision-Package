using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Vision_Package
{
    public abstract class Filter
    {
        /// <summary>
        ///  Applay Filtter For An Specific Image
        /// </summary>
        public abstract void ApplayFilter(_Image ApplayImage);
        /// <summary>
        /// Get The Name For Specifid Filter
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

    }
}
