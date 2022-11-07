using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal static class Control
    {
       /// <summary>
       /// Önce modelimizin tipini aldık. Sonra o tipteki propertyler dolaşılır ve 
       /// o propertylere attribute uygulanmış mı bakılır. Attributelerin listesi alınır.
       /// </summary>
       /// <param name="Attribute Oluşturma"></param>
       /// <returns></returns>

        public static bool Check(Person person)
        {
            Type type = person.GetType();
            foreach (var item in type.GetProperties())
            {
                var attributeList = item.GetCustomAttributes(typeof(RequiredAttribute), true);
                if(attributeList.Any())
                {
                    var value = item.GetValue(person);
                    if (value == null)
                        return false;
                }         
            }
            return true;
        }
    }
}
