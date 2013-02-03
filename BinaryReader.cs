#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.IO;

namespace KSP.IO
{
    /// <summary>
    /// Identical to System.IO.BinaryReader, but with added IDisposable methods (for use in using structures), and a factory method instead of constructors.
    /// </summary>
    public class BinaryReader : IDisposable
    {
        public extern Stream BaseStream { get; }

        public extern void Close();
        /// <summary>
        /// Create a binary reader with the desired filename.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static BinaryReader CreateForType<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Close the stream and any resources (e.g. files) it has open.
        /// </summary>
        public extern void Dispose();
        public extern int PeekChar();
        public extern int Read();
        /// <summary>
        /// Read a block of bytes from the stream.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public extern int Read(byte[] buffer, int index, int count);
        /// <summary>
        /// Read a block of chars from the stream.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public extern int Read(char[] buffer, int index, int count);
        public extern bool ReadBoolean();
        public extern byte ReadByte();
        public extern byte[] ReadBytes(int count);
        public extern char ReadChar();
        public extern char[] ReadChars(int count);
        public extern decimal ReadDecimal();
        public extern double ReadDouble();
        public extern short ReadInt16();
        public extern int ReadInt32();
        public extern long ReadInt64();
        public extern sbyte ReadSByte();
        public extern float ReadSingle();
        public extern string ReadString();
        public extern ushort ReadUInt16();
        public extern uint ReadUInt32();
        public extern ulong ReadUInt64();
    }
}
