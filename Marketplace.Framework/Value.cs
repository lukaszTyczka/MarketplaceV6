using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Framework;
public abstract class Value<T> where T : Value<T>
{
    private static readonly Member[] Members = GetMembers().ToArray();

    private static IEnumerable<Member> GetMembers()
    {
        throw new NotImplementedException();
    }

    private struct Member
    {
        public readonly string Name;
        public readonly Func<object, object> GetValue;
        public readonly bool IsNonStringEnumerable;
        public readonly Type Type;

        public Member(MemberInfo info)
        {
            switch (info)
            {
                case FieldInfo field:
                    Name = field.Name;
                    GetValue = obj => field.GetValue(obj);
                    IsNonStringEnumerable = typeof(IEnumerable).IsAssignableFrom(field.FieldType) && field.FieldType != typeof(string);
                    Type = field.FieldType;
                    break;
                case PropertyInfo property:
                    Name = property.Name;
                    GetValue = obj => property.GetValue(obj);
                    IsNonStringEnumerable = typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string);
                    Type = property.PropertyType;
                    break;
                default:
                    throw new ArgumentException("Member is not a field of property?!?!", info.Name);
            }
        }
    }
}
