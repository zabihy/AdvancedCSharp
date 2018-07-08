using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAccessorByILGenerator
{
    public static class TypeExtension
    {
        public static object GetPropertyByAccessor(this Type type, string propertyName, object obj)
        {
            PropertyAccessor accessor = new PropertyAccessor(type, propertyName);

            return accessor.GetValue(obj);
        }

        public static void SetPropertyByAccessor(this Type type, string propertyName, object obj, object value)
        {
            PropertyAccessor accessor = new PropertyAccessor(type, propertyName);

            accessor.SetValue(obj, value);
        }
    }
}
