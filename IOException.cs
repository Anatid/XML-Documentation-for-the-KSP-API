#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

namespace KSP.IO
{
    /// <summary>
    /// A surrogate for System.IO.IOException.
    /// </summary>
    public class IOException : Exception
    {
        protected string message;
        protected string source;
        protected string stack;

        public extern IOException(string message, string source, string stack);

        public extern override string Message { get; }
        public extern override string Source { get; }
        public extern override string StackTrace { get; }
    }
}
