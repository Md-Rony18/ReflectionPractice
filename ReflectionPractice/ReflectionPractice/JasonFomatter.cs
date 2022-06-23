using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractice
{
    public static class JasonFomatter
    {
        public static string Convert<T>(T item)
        {
            PropertyInfo[] properties = item.GetType().GetProperties();
            string property = "";
            string propertyvalue="";
            foreach (PropertyInfo items in properties)
            {
                Console.WriteLine($"\"{items.Name}\":\"{items.GetValue(item)}\",");

                if (items.PropertyType.IsClass && !items.PropertyType.FullName.StartsWith("System."))
                {
                     Convert(items.GetValue(item));
                }
            }
            //return "{\n" + "  " + property + ":" + propertyvalue + "\n" + "}";

            return "";
        }
        public static int count = 0;
        public static string next1,next2;
        public static string Stringloop<T>(T item)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType(item.ToString());
            var names = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            string propertyname = "";
            //object propertyvalue = "";
            if (names.Length > 0)
            {
                count++;
                propertyname += Stringloop(names.Length-1);

            }
            else {
                return null;

            }
            return "{" + propertyname + "}";


        }
        public static int num, ins;
        public static int Arrayconveter(int item)
        {
            if (item==1 || item==2)
            {
                return 1;
            }
            //for (int i = 0; i < item.length; i++)
            //{

            //}
            int result = Arrayconveter(item - 1) + Arrayconveter(item - 2);
            return result;
        }
    }
}
