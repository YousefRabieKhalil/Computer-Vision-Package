using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlingClasses;
using AdditionalForms;

namespace Computer_Vision_Package.Filters
{
    class Dilation : Filter
    {
        public override void ApplayFilter(_Image ApplayImage)
        {
            throw new NotImplementedException();
        }

        public override bool HasAditionalForm()
        {
            return true;
        }

        public override void ShowFilterForm()
        {
            StrucutureElemntChoose NewForm = new StrucutureElemntChoose();
            NewForm.ShowDialog();
        }

        public override string ToString()
        {
            return "Dilation-Filter";
        }
    }
}
