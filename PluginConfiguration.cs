#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Reflection;

namespace KSP.IO
{
    /// <summary>
    /// From N3X15: PluginConfiguration was something I threw together a while ago to try and improve settings serialization. The INI files we were using just couldn't cope with newlines and had all sorts of horrible workarounds. Instead of INI files, it writes structured XML files that look like this:
    /// 
    /// <para><code>
    /// &lt;config&gt;
    ///    &lt;int name="int"\&gt;4&lt;/int&gt;
    ///    &lt;long name="long"&gt;45&lt;/long&gt;
    ///    &lt;short name="short"&gt;4&lt;/short&gt;
    ///    &lt;byte name="byte"&gt;255&lt;/byte&gt;
    ///    &lt;bool name="bool"&gt;1&lt;/bool&gt;
    ///    &lt;vector3 name="vector3"&gt;
    ///        &lt;x&gt;0&lt;/x&gt;
    ///        &lt;y&gt;1&lt;/y&gt;
    ///        &lt;z&gt;2&lt;/z&gt;
    ///    &lt;/vector3&gt;
    ///    &lt;vector3d name="vector3d"&gt;
    ///        &lt;x&gt;0&lt;/x&gt;
    ///        &lt;y&gt;1&lt;/y&gt;
    ///        &lt;z&gt;2.05&lt;/z&gt;
    ///    &lt;/vector3d&gt;
    ///    &lt;string name="string"&gt;string&lt;/string&gt;
    ///  &lt;/config&gt;
    ///  </code></para>
    ///  
    /// <para>Despite looking a bit messy, it's actually a lot easier to use and doesn't have as many drawbacks as INI files. Newlines are preserved, and most importantly, types are also preserved. Oh, and it's UTF-8 encoded, so internationalization won't be as much as a problem, theoretically. Here's how to use it:</para>
    /// <para><code>
    /// PluginConfiguration cfg = PluginConfiguration.CreateForType&lt;MyCoolModule&gt;();
    /// cfg["a string"] = "I love KSP!";
    /// cfg["another setting"] = new Vector3d(0,1,2);
    /// cfg.save();
    /// // Later...
    /// cfg.load();
    /// settingAString = cfg.GetValue&lt;string&gt;("a string");
    /// settingAVector = cfg.GetValue&lt;Vector3d&gt;("another setting");
    /// </code></para>
    /// </summary>
    public class PluginConfiguration
    {
        protected extern PluginConfiguration(string pathToFile);

        /// <summary>
        /// Return configuration key from the root node
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public extern object this[string key] { get; set; }

        /// <summary>
        /// Initialize the configuration object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flight"></param>
        /// <returns></returns>
        public extern static PluginConfiguration CreateForType<T>(Vessel flight = null);
        /// <summary>
        /// Get a typed value from the root node.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public extern T GetValue<T>(string key);
        /// <summary>
        /// Get a typed value from the root node, and set to a default if it doesn't exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="_default"></param>
        /// <returns></returns>
        public extern T GetValue<T>(string key, T _default);
        /// <summary>
        /// Load from disk
        /// </summary>
        public extern void load();
        /// <summary>
        /// Commit changes to disk
        /// </summary>
        public extern void save();
        /// <summary>
        /// Set a configuration key's value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public extern void SetValue(string key, object value);
    }
}
