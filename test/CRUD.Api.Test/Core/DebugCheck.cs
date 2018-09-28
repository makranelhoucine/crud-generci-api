namespace CRUD.Api.Test.Core
{
    using System.Diagnostics;

    internal class DebugCheck
    {
        /// <summary>
        /// Assert the value is not null.
        /// </summary>
        /// <typeparam name="T">The reference type. </typeparam>
        /// <param name="value">The value. </param>
        [Conditional("DEBUG")]
        public static void NotNull<T>(T value)
            where T : class
        {
            Debug.Assert(value != null, "The value should not be null.");
        }
    }
}