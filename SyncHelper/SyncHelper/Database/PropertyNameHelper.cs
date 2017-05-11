using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SyncHelper.Database
{
    public static class PropertyNameHelper
    {

        public static void ExposeProperty<T>(Expression<Func<T>> property)
        {
            var expression = GetMemberInfo(property);
            string path = string.Concat(expression.Member.DeclaringType.FullName,
                ".", expression.Member.Name);
            // Do ExposeProperty work here...

        }
    }
}
