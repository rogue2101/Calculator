using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculatorDLL
{
    public class Calculator
    {
        public T Add<T>(T item1, T item2)
        {
            try
            {
                dynamic num1 = ConvertToNumeric(item1);
                dynamic num2 = ConvertToNumeric(item2);
                return (T)Convert.ChangeType(num1+num2, typeof(T));
            }
            catch (Exception ex)
            {
                return (T)Convert.ChangeType("Please enter a valid numeric type.", typeof(T));
            }
        }
        public T Multiply<T>(T item1, T item2)
        {
            try
            {
                dynamic num1 = ConvertToNumeric(item1);
                dynamic num2 = ConvertToNumeric(item2);
                return (T)Convert.ChangeType(num1*num2, typeof(T));
            }
            catch (Exception ex)
            {
                throw new Exception("Please enter a valid numeric type.");
            }
        }
        public T Substract<T>(T item1, T item2)
        {
            try
            {
                dynamic num1 = ConvertToNumeric(item1);
                dynamic num2 = ConvertToNumeric(item2);
                return (T)Convert.ChangeType(num1-num2, typeof(T));
            }
            catch (Exception ex)
            {
                throw new Exception("Please enter a valid numeric type.");
            }
        }
        public T Divide<T>(T item1, T item2)
        {
            try
            {
                dynamic num1 = ConvertToNumeric(item1);
                dynamic num2 = ConvertToNumeric(item2);
                return (T)Convert.ChangeType(num1/num2, typeof(T));
            }
            catch (Exception ex)
            {
                throw new Exception("Please enter a valid numeric type.");
            }
        }
        public static dynamic ConvertToNumeric<T>(T  item)
        {
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if(item is string s)
            {
                return Convert.ToDouble(s);
            }
            if(item is IConvertible)
            {
                return Convert.ChangeType(item, typeof(double));
            }
            return "Invalid Type";
        }
    }
}
