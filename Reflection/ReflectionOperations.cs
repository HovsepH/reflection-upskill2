using System.Reflection;

[assembly: CLSCompliant(true)]

namespace Reflection
{
    public static class ReflectionOperations
    {
        public static string GetTypeName(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            return type.Name;
        }

        public static string GetFullTypeName<T>()
        {
            Type type = typeof(T);
            if (type.FullName == null)
            {
                throw new ArgumentNullException();
            }

            return type.FullName;
        }

        public static string GetAssemblyQualifiedName<T>()
        {
            Type type = typeof(T);
            return type.AssemblyQualifiedName;
        }

        public static string[] GetPrivateInstanceFields(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            string[] fieldNames = new string[fields.Length];
            for (int i = 0; i < fields.Length; i++)
            {
                fieldNames[i] = fields[i]?.ToString() ?? " ";
            }

            return fieldNames;
        }

        public static string[] GetPublicStaticFields(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
            string[] fieldNames = new string[fields.Length];
            for (int i = 0; i < fields.Length; i++)
            {
                fieldNames[i] = fields[i]?.ToString() ?? " ";
            }

            return fieldNames;
        }

        public static string?[] GetInterfaceDataDetails(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            var interfaces = type.GetInterfaces();
            string?[] interfaceDetails = new string?[interfaces.Length];
            for (int i = 0; i < interfaces.Length; i++)
            {
                string interfaceName = interfaces[i].ToString();
                interfaceDetails[i] = interfaceName;
            }

            return interfaceDetails;
        }

        public static string?[] GetConstructorsDataDetails(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            string?[] constructorDetails = new string?[constructors.Length];
            for (int i = 0; i < constructors.Length; i++)
            {
                constructorDetails[i] = constructors[i].ToString();
            }

            return constructorDetails;
        }

        public static string?[] GetTypeMembersDataDetails(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            MemberInfo[] members = type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            string?[] membersDetails = new string?[members.Length];
            for (int i = 0; i < members.Length; i++)
            {
                membersDetails[i] = members[i].ToString();
            }

            return membersDetails;
        }

        public static string?[] GetMethodDataDetails(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            string?[] methodDetails = new string?[methods.Length];
            for (int i = 0; i < methods.Length; i++)
            {
                methodDetails[i] = methods[i].ToString();
            }

            return methodDetails;
        }

        public static string?[] GetPropertiesDataDetails(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "The object cannot be null.");
            }

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            string?[] propDetails = new string?[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                propDetails[i] = properties[i].ToString();
            }

            return propDetails;
        }
    }
}
