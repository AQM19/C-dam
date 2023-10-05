using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UT5E04
{
    internal class AsisteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool asiste = (bool)value;
            return asiste ? "Presente" : "No";

            /* Forma original de hacerlo según el manual
            switch (value.ToString())
            {
                case "yes":
                case "si":
                    return true;
                case "not":
                case "no":
                    return false;
            }
            return false;
            */


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? "Presente" : "No";
            /* Forma original de hacerlo según el manual
            if (value is bool)
            {
                if ((bool)value)
                {
                    return "Presente";
                }
                else
                {
                    return "No";
                }
            }
            return "no";
            */
        }
    }
}
