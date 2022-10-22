using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MansStore
{
    public static class EnumHelper<T>
    {
        public static IList<T> GetValue(Enum Value)
        {
            var enumvalue = new List<T>();
            foreach (FieldInfo fi in Value.GetType().GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                enumvalue.Add((T)Enum.Parse(Value.GetType(), fi.Name, false));
            }
            return enumvalue;
        }
        public static T Parse(string Value)
        {
            return (T)Enum.Parse(typeof(T), Value, true);
        }
        public static IList<string>GetNames(Enum Value)
        {
            return Value.GetType().GetFields(BindingFlags.Static | BindingFlags.Public).Select(fi=>fi.Name).ToList();    
        }
        //private static string lookupResourse(Type ResourseManageProvider, string resourekey)
        //{
        //    foreach (PropertyInfo staticproperty in ResourseManageProvider.GetProperties(BindingFlags.Static | BindingFlags.Public))
        //    {
        //        if (staticproperty.PropertyType == typeof(System.Resources.ResourceManager))
        //        {
        //            System.Resources.ResourceManager resourceManager = (System.Resources.ResourceManager)staticproperty.;
        //            return resourceManager.GetString(resourekey);
        //        }
        //    }
        //}
        //public static string GetDisPlayValue(T value)
        //{
        //    try
        //    {
        //        var filedinfo = value.GetType().GetField(value.ToString());
        //        var discriptionAttribute = filedinfo.GetCustomAttributes(
        //            typeof(DisplayAttribute), false) as DisplayAttribute[];
        //        if (discriptionAttribute[0].ResourceType !=null)
        //        {
        //            return look
        //        }
                    
                    
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
