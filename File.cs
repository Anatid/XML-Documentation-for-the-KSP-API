#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

namespace KSP.IO
{
    public class File
    {
        public extern File();

        /// <summary>
        /// Append a string to a file, or creates it if it doesn't exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        public extern static void AppendAllText<T>(string data, string filename, Vessel flight = null);
        /// <summary>
        /// Open a stream that appends to a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static TextWriter AppendText<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Open a stream that creates a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static FileStream Create<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Open a stream that creates a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static TextWriter CreateText<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Delete a file in your IO sandbox.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        public extern static void Delete<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Find out if a file in your IO sandbox exists.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static bool Exists<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Open a stream that operates on a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="mode"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static FileStream Open<T>(string filename, FileMode mode, Vessel flight = null);
        /// <summary>
        /// Open a stream that operates on a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static TextReader OpenText<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Open a stream that writes to a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static FileStream OpenWrite<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Read all the bytes from a file in your IO sandbox.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        public extern static byte[] ReadAllBytes<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Read all lines from a file in your IO sandbox.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static string[] ReadAllLines<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Read all the text from a file in your IO sandbox.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static string ReadAllText<T>(string filename, Vessel flight = null);
        /// <summary>
        /// Write a bunch of bytes to a file on disk
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        public extern static void WriteAllBytes<T>(byte[] data, string filename, Vessel flight = null);
        /// <summary>
        /// Write an array of strings to a file, with each string becoming a line.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        public extern static void WriteAllLines<T>(string[] data, string filename, Vessel flight = null);
        /// <summary>
        /// Write a string to a file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="filename"></param>
        /// <param name="flight"></param>
        public extern static void WriteAllText<T>(string data, string filename, Vessel flight = null);
    }
}
