#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Reflection;

namespace KSP.IO
{
    /// <summary>
    /// A node full of configuration values.
    /// </summary>
    public class PluginConfigNode
    {
        public extern PluginConfigNode();
        public extern PluginConfigNode(PluginConfigNode parent);

        /// <summary>
        /// Get or set the value of a configuration key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public extern object this[string key] { get; set; }

        /// <summary>
        /// Gets the parent of this node.
        /// </summary>
        /// <returns></returns>
        public extern PluginConfigNode GetParent();
        /// <summary>
        /// Get the value of a configuration key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public extern T GetValue<T>(string key);
        /// <summary>
        /// Get the value of a configuration key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="_default"></param>
        /// <returns></returns>
        public extern T GetValue<T>(string key, T _default);
        /// <summary>
        /// Set the value of a configuration key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public extern void SetValue(string key, object value);
    }
}
