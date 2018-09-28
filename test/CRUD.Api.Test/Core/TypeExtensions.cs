namespace CRUD.Api.Test.Core
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    internal static class TypeExtensions
    {
        /// <summary>
        /// Get declared methods.
        /// </summary>
        /// <param name="type">The <see cref="Type"/>.</param>
        /// <returns>The methods.</returns>
        public static IEnumerable<MethodInfo> GetDeclaredMethods(this Type type)
        {
            DebugCheck.NotNull(type);
            return type.GetTypeInfo().DeclaredMethods;
        }
    }
}