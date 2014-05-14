#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

namespace KSP.IO
{
    /// <summary>
    /// This enum is a replacement for its System.IO equivalent. It's used to determine from where one wishes to seek in a file stream.
    /// </summary>
    public enum SeekOrigin
    {
        /// <summary>
        /// Seek from the beginning of the stream.
        /// </summary>
        Begin = 0,
        /// <summary>
        /// Seek from the current position in the stream.
        /// </summary>
        Current = 1,
        /// <summary>
        /// Seek from the end of the stream.
        /// </summary>
        End = 2,
    }
}
