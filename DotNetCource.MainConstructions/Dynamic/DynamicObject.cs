using System.Linq.Expressions;
using System.Xml;

namespace DotNetCource.MainConstructions.Dynamic
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class DynamicObject
    {
        public dynamic this[string name]
        {
            get
            {
                var currentType = GetType();
                var memberInfo = currentType.GetMember(name).FirstOrDefault();

                if (memberInfo == null)
                    throw new ArgumentException(nameof(name));

                if (memberInfo is MethodInfo methodInfo)
                {
                    Type delegateType;
                    var paramTypes = methodInfo.GetParameters()
                        .Select(param => param.ParameterType)
                        .ToList();

                    if (methodInfo.ReturnType == typeof(void))
                    {
                        delegateType = Expression.GetActionType(paramTypes.ToArray());
                    }
                    else
                    {
                        paramTypes.Add(methodInfo.ReturnType);
                        delegateType = Expression.GetFuncType(paramTypes.ToArray());
                    }

                    var resultDelegateType = delegateType.IsGenericTypeDefinition
                        ? delegateType.MakeGenericType(paramTypes.ToArray())
                        : delegateType;

                    return methodInfo.CreateDelegate(resultDelegateType, this);
                }

                if (memberInfo is FieldInfo fieldInfo)
                    return fieldInfo.GetValue(this);
                if (memberInfo is PropertyInfo propertyInfo)
                    return propertyInfo.GetValue(this);

                throw new ArgumentException(nameof(name));
            }
        }
    }
}