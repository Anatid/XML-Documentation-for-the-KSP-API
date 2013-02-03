#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

namespace KSP.IO
{
    /// <summary>
    /// Useful for manipulating bytes in memory.
    /// </summary>
    public class MemoryStream
    {
        public extern MemoryStream();
        public extern MemoryStream(byte[] buffer);

        public extern bool CanRead { get; }
        public extern bool CanSeek { get; }
        public extern bool CanWrite { get; }
        public extern int Capacity { get; set; }
        public extern long Length { get; }
        public extern long Position { get; set; }

        public extern void Flush();
        public extern byte[] GetBuffer();
        public extern int Read(byte[] buffer, int offset, int count);
        public extern int ReadByte();
        public extern long Seek(long offset, SeekOrigin loc);
        public extern void SetLength(long value);
        public extern byte[] ToArray();
        public extern void Write(byte[] buffer, int offset, int count);
        public extern void WriteByte(byte value);
    }
}
