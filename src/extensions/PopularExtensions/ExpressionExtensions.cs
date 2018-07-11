using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace PopularExtensions
{
    public static class ExpressionExtensions
    {
        public static string GetName<T, TResult>(this Expression<Func<T, TResult>> expression)
        {
            return GetUnchangedName(expression).ToLower();
        }

        private static string GetUnchangedName<T, TResult>(Expression<Func<T, TResult>> expression)
        {
            return (expression.Body as MemberExpression ?? ((UnaryExpression)expression.Body).Operand as MemberExpression).Member.Name;
        }
        public static IEnumerable<string> GetListName<T, TResult>(this Expression<Func<T, TResult>> expression)
        {
            if (expression.Body is MemberExpression)
            {
                return new string[] { ((MemberExpression)expression.Body).Member.Name }.ToList();
            }
            else if (expression.Body is UnaryExpression)
            {
                return new string[] { (((UnaryExpression)expression.Body).Operand as MemberExpression).Member.Name }.ToList();
            }
            else
                if (expression.Body is NewExpression)
            {
                var members = ((NewExpression)expression.Body).Members?.ToList();

                var result = new List<string>();
                if (members != null)
                {
                    foreach (var item in members)
                    {
                        result.Add(item.Name);
                    }
                }

                return result;
            }
            throw new InvalidCastException();
        }

        public static PropertyInfo GetPropertyInfo<T, TResult>(this Expression<Func<T, TResult>> expression)
        {
            var name = GetUnchangedName(expression);

            return typeof(T).GetProperties().FirstOrDefault(p => p.Name == name);
        }
    }

}
