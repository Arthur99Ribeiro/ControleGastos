using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    public class Helper
    {
        public static class CheckBoxHelper
        {
            // Converte de CheckBox para "S" ou "N"
            public static string SorN(CheckBox checkBox)
            {
                return checkBox.Checked ? "S" : "N";
            }

            // Converte de "S" ou "N" para CheckBox
            public static void TorF(CheckBox checkBox, string valor)
            {
                checkBox.Checked = valor?.Trim().ToUpper() == "S";
            }
        }
    }
}
