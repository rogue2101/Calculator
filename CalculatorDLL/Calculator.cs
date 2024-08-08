using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.CodeDom;

namespace CalculatorDLL
{
    public class Calculator
    {
        List<Type> typeList = new List<Type>();
        public Calculator()
        {
            typeList.Add(typeof(int));
            typeList.Add(typeof(double));
            typeList.Add(typeof(long));
            typeList.Add(typeof(float));
            typeList.Add(typeof(string));
        }
        public dynamic Add(dynamic item1, dynamic item2)
        {
            if(!typeList.Contains(item1.GetType()) && !typeList.Contains(item2.GetType()))
            {
                return "Please enter a numeric value.";
            }

            if (item1.GetType() == typeof(string) && item2.GetType() == typeof(string))
            {
                var num1 = GetParsedValue(item1, typeList);
                var num2 = GetParsedValue(item2, typeList);
                if(num1 == null || num2 == null)
                {
                    return "Please enter valid numeric value.";
                }
                return num1+num2;
            }
            else
            {
                var result = item1 + item2;
                return result;
            }
            return "Please enter a valid number";
        }
        public dynamic Multiply(dynamic item1, dynamic item2)
        {
            if (!typeList.Contains(item1.GetType()) && !typeList.Contains(item2.GetType()))
            {
                return "Please enter a numeric value.";
            }

            if (item1.GetType() == typeof(string) && item2.GetType() == typeof(string))
            {
                var num1 = GetParsedValue(item1, typeList);
                var num2 = GetParsedValue(item2, typeList);
                if (num1 == null || num2 == null)
                {
                    return "Please enter valid numeric value.";
                }
                return num1 * num2;
            }
            else
            {
                var result = item1 * item2;
                return result;
            }
            return "Please enter a valid number";
        }
        public dynamic Substract(dynamic item1, dynamic item2)
        {
            if (!typeList.Contains(item1.GetType()) && !typeList.Contains(item2.GetType()))
            {
                return "Please enter a numeric value.";
            }

            if (item1.GetType() == typeof(string) && item2.GetType() == typeof(string))
            {
                var num1 = GetParsedValue(item1, typeList);
                var num2 = GetParsedValue(item2, typeList);
                if (num1 == null || num2 == null)
                {
                    return "Please enter valid numeric value.";
                }
                return num1 - num2;
            }
            else
            {
                var result = item1 - item2;
                return result;
            }
            return "Please enter a valid number";
        }
        public dynamic Divide(dynamic item1, dynamic item2)
        {
            if (!typeList.Contains(item1.GetType()) && !typeList.Contains(item2.GetType()))
            {
                return "Please enter a numeric value.";
            }

            if (item1.GetType() == typeof(string) && item2.GetType() == typeof(string))
            {
                var num1 = GetParsedValue(item1, typeList);
                var num2 = GetParsedValue(item2, typeList);
                if(num1 == null || num2 == null)
                {
                    return "Please enter valid numeric value.";
                }
                return num1 / num2;
            }
            else
            {
                var result = item1 / item2;
                return result;
            }
            return "Please enter a valid number";
        }

        static object GetParsedValue(string str, List<Type> typeList)
        {
            if (typeList.Contains(typeof(int)) && int.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out int intValue))
            {
                return intValue;
            }
            if (typeList.Contains(typeof(int)) && double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
            {
                return doubleValue;
            }
            if (typeList.Contains(typeof(int)) && long.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out long longValue))
            {
                return longValue;
            }
            if (typeList.Contains(typeof(int)) && float.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out float floatValue))
            {
                return floatValue;
            }
            return null;
        }
    }
}
