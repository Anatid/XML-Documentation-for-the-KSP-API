#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Text;

namespace KSP.IO
{
    /// <summary>
    /// Identical to System.IO.TextWriter, but with added IDisposable methods (for use in using() statements), and a factory method instead of constructors.
    /// </summary>
    public class TextWriter : IDisposable
    {
        public extern Encoding Encoding { get; }
        public extern IFormatProvider FormatProvider { get; }
        public extern string NewLine { get; set; }

        public extern void Close();
        /// <summary>
        /// Create a text writing stream
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static TextWriter CreateForType<T>(string filename, Vessel flight = null);
        public extern void Dispose();
        public extern void Flush();
        public extern void Write(bool value);
        public extern void Write(char value);
        public extern void Write(char[] buffer);
        public extern void Write(decimal value);
        public extern void Write(double value);
        public extern void Write(float value);
        public extern void Write(int value);
        public extern void Write(long value);
        public extern void Write(object value);
        public extern void Write(string value);
        public extern void Write(uint value);
        public extern void Write(ulong value);
        public extern void Write(string format, object arg0);
        public extern void Write(string format, params object[] arg);
        public extern void Write(char[] buffer, int index, int count);
        public extern void Write(string format, object arg0, object arg1);
        public extern void Write(string format, object arg0, object arg1, object arg2);
        public extern void WriteLine();
        public extern void WriteLine(bool value);
        public extern void WriteLine(char value);
        public extern void WriteLine(char[] buffer);
        public extern void WriteLine(decimal value);
        public extern void WriteLine(double value);
        public extern void WriteLine(float value);
        public extern void WriteLine(int value);
        public extern void WriteLine(long value);
        public extern void WriteLine(object value);
        public extern void WriteLine(string value);
        public extern void WriteLine(uint value);
        public extern void WriteLine(ulong value);
        public extern void WriteLine(string format, object arg0);
        public extern void WriteLine(string format, params object[] arg);
        public extern void WriteLine(char[] buffer, int index, int count);
        public extern void WriteLine(string format, object arg0, object arg1);
        public extern void WriteLine(string format, object arg0, object arg1, object arg2);
    }
}
