#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.IO;
using System.Text;

namespace KSP.IO
{
    /// <summary>
    /// Identical to System.IO.TextReader, but with added IDisposable methods (for use in using() statements), and a factory method instead of constructors.
    /// </summary>
    public class TextReader : IDisposable
    {
        public extern Stream BaseStream { get; }
        public extern Encoding CurrentEncoding { get; }
        public extern bool EndOfStream { get; }

        public extern void Close();
        /// <summary>
        /// Create a text reader stream.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static TextReader CreateForType<T>(string filename, Vessel flight = null);
        public extern void DiscardBufferedData();
        public extern void Dispose();
        public extern int Peek();
        public extern int Read();
        public extern int Read(char[] buffer, int index, int count);
        public extern string ReadLine();
        public extern string ReadToEnd();
    }
}
