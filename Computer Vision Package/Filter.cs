using ControlingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Vision_Package
{
    public abstract class Filter
    {
        public List<object> FilterInputs;
        /// <summary>
        ///  Applay Filtter For An Specific Image
        /// </summary>
        public abstract void ApplayFilter(_Image ApplayImage);
        /// <summary>
        /// Get The Name For Specifid Filter
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();


        /// <summary>
        /// Check if The Filter Has A Form Or not
        /// </summary>
        /// <returns> Filter Has A form Or Not </returns>
        public abstract bool HasAditionalForm();

        /// <summary>
        /// Show THe Filter Form
        /// </summary>
        public abstract void ShowFilterForm();
    }
}
