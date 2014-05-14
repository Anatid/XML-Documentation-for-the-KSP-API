#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

namespace KSP.IO
{
    /// <summary>
    /// Has some useful little tools and utilities.
    /// </summary>
    public class IOUtils
    {
        public extern IOUtils();

        /// <summary>
        /// Deserialize a binary serialized object
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public extern static object DeserializeFromBinary(byte[] input);
        /// <summary>
        /// Return the full path for a given filename, provided a class from the plugin. 
        /// <para>PluginData/[.flights/FLIGHT_UUID/]assemblyname/file</para>
        /// </summary>
        /// <param name="T"></param>
        /// <param name="file"></param>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static string GetFilePathFor(Type T, string file, Vessel flight = null);
        /// <summary>
        /// Serialize an object (same as using a BinaryFormatter).
        /// </summary>
        /// <param name="something"></param>
        /// <returns></returns>
        public extern static byte[] SerializeToBinary(object something);
    }
}
