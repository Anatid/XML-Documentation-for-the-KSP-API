#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.IO;

namespace KSP.IO
{
    /// <summary>
    /// Identical to System.IO.BinaryWriter, but with added IDisposable methods (for use in using structures), and a factory method instead of constructors.
    /// </summary>
    public class BinaryWriter : IDisposable
    {
        public extern Stream BaseStream { get; }

        public extern void Close();
        /// <summary>
        /// Create a binary file writer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static BinaryWriter CreateForType<T>(string filename, Vessel flight = null);
        public extern void Dispose();
        public extern void Flush();
        public extern long Seek(int offset, SeekOrigin origin);
        public extern void Write(bool value);
        public extern void Write(byte value);
        public extern void Write(byte[] buffer);
        public extern void Write(char ch);
        public extern void Write(char[] chars);
        public extern void Write(decimal value);
        public extern void Write(double value);
        public extern void Write(float value);
        public extern void Write(int value);
        public extern void Write(long value);
        public extern void Write(sbyte value);
        public extern void Write(short value);
        public extern void Write(string value);
        public extern void Write(uint value);
        public extern void Write(ulong value);
        public extern void Write(ushort value);
        public extern void Write(byte[] buffer, int index, int count);
        public extern void Write(char[] chars, int index, int count);
    }
}
