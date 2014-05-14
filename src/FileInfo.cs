#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

namespace KSP.IO
{
    /// <summary>
    /// A surrogate for System.IO.FileInfo.
    /// </summary>
    public class FileInfo
    {
        /// <summary>
        /// Gets a string representing the directory's full path.
        /// </summary>
        public extern string DirectoryName { get; }
        /// <summary>
        /// Gets a value indicating whether a file exists.
        /// </summary>
        public extern bool Exists { get; }
        /// <summary>
        /// Gets or sets a value that determines if the current file is read only.
        /// </summary>
        public extern bool IsReadOnly { get; set; }
        /// <summary>
        /// Gets the size, in bytes, of the current file.
        /// </summary>
        public extern long Length { get; }
        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        public extern string Name { get; }

        /// <summary>
        /// Creates a System.IO.StreamWriter that appends text to the file represented by this instance of the System.IO.FileInfo.
        /// </summary>
        /// <returns></returns>
        public extern TextWriter AppendText();
        /// <summary>
        /// Copies an existing file to a new file, disallowing the overwriting of an existing file.
        /// </summary>
        /// <param name="destFileName"></param>
        /// <returns></returns>
        public extern FileInfo CopyTo(string destFileName);
        /// <summary>
        /// Copies an existing file to a new file, allowing the overwriting of an existing file.
        /// </summary>
        /// <param name="destFileName"></param>
        /// <param name="overwrite"></param>
        /// <returns></returns>
        public extern FileInfo CopyTo(string destFileName, bool overwrite);
        /// <summary>
        /// Creates a file.
        /// </summary>
        /// <returns></returns>
        public extern FileStream Create();
        /// <summary>
        /// Create a text reader stream.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static FileInfo CreateForType<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Creates a KSP.IO.TextWriter that writes a new text file.
        /// </summary>
        /// <returns></returns>
        public extern TextWriter CreateText();
        /// <summary>
        /// Decrypts a file that was encrypted by the current account using the System.IO.FileInfo.Encrypt() method.
        /// </summary>
        public extern void Decrypt();
        /// <summary>
        /// Permanently deletes a file.
        /// </summary>
        public extern void Delete();
        /// <summary>
        /// Encrypts a file so that only the account used to encrypt the file can decrypt it.
        /// </summary>
        public extern void Encrypt();
        /// <summary>
        /// Moves a specified file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="destFileName"></param>
        public extern void MoveTo(string destFileName);
        /// <summary>
        /// Opens a file in the specified mode.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public extern FileStream Open(FileMode mode);
        /// <summary>
        /// Opens a file in the specified mode with read, write, or read/write access.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <returns></returns>
        public extern FileStream Open(FileMode mode, FileAccess access);
        /// <summary>
        /// Opens a file in the specified mode with read, write, or read/write access and the specified sharing option.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="access"></param>
        /// <param name="share"></param>
        /// <returns></returns>
        public extern FileStream Open(FileMode mode, FileAccess access, FileShare share);
        /// <summary>
        /// Creates a read-only System.IO.FileStream.
        /// </summary>
        /// <returns></returns>
        public extern FileStream OpenRead();
        /// <summary>
        /// Creates a System.IO.StreamReader with UTF8 encoding that reads from an existing text file.
        /// </summary>
        /// <returns></returns>
        public extern TextReader OpenText();
        /// <summary>
        /// Creates a write-only System.IO.FileStream.
        /// </summary>
        /// <returns></returns>
        public extern FileStream OpenWrite();
        /// <summary>
        /// Replaces the contents of a specified file with the file described by the current System.IO.FileInfo object, deleting the original file, and creating a backup of the replaced file.
        /// </summary>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <returns></returns>
        public extern FileInfo Replace(string destinationFileName, string destinationBackupFileName);
        /// <summary>
        /// Replaces the contents of a specified file with the file described by the current System.IO.FileInfo object, deleting the original file, and creating a backup of the replaced file. Also specifies whether to ignore merge errors.
        /// </summary>
        /// <param name="destinationFileName"></param>
        /// <param name="destinationBackupFileName"></param>
        /// <param name="ignoreMetadataErrors"></param>
        /// <returns></returns>
        public extern FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
        /// <summary>
        /// Returns the path as a string.
        /// </summary>
        /// <returns></returns>
        public extern string ToString();
    }
}
