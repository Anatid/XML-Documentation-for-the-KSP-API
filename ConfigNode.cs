#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

/// <summary>
/// A ConfigNode represents a collection of data that can be serialized to or deserialized from a file.
/// A ConfigNode contains a set of values, and optionally
/// one or more ConfigNodes, so they can be used recursively.
/// </summary>
[Serializable]
public class ConfigNode
{
    public const string configTabIndent = @"	";

    public string name;

    public extern ConfigNode();
    public extern ConfigNode(string name);

    public extern int CountNodes { get; }
    public extern int CountValues { get; }
    public extern bool HasData { get; }
    public extern ConfigNode.ConfigNodeList nodes { get; }
    public extern ConfigNode.ValueList values { get; }

    /// <summary>
    /// Add a sub-ConfigNode with a given name to this node.
    /// </summary>
    /// <param name="name">The name of the new node</param>
    /// <returns>The newly created sub-ConfigNode</returns>
    public extern ConfigNode AddNode(string name);
    /// <summary>
    /// Add a new piece of data to this ConfigNode. Values show up in serialized ConfigNodes as lines of the form
    /// <para><code>name = value</code></para>
    /// </summary>
    /// <param name="name">The name of the new value.</param>
    /// <param name="value">The data to store.</param>
    public extern void AddValue(string name, object value);
    /// <summary>
    /// Add a new piece of data to this ConfigNode. Values show up in serialized ConfigNodes as lines of the form
    /// <para><code>name = value</code></para>
    /// </summary>
    /// <param name="name">The name of the new value.</param>
    /// <param name="value">The data to store.</param>
    public extern void AddValue(string name, string value);
    /// <summary>
    /// Remove all nodes and values?
    /// </summary>
    public extern void ClearData();
    /// <summary>
    /// Remove all sub-ConfigNodes from this ConfigNode?
    /// </summary>
    public extern void ClearNodes();
    /// <summary>
    /// Remove all values from this ConfigNode?
    /// </summary>
    public extern void ClearValues();
    /// <summary>
    /// Copies the contents of this node into a different ConfigNode
    /// </summary>
    /// <param name="node">The ConfigNode to copy this one into.</param>
    public extern void CopyTo(ConfigNode node);
    /// <summary>
    /// Create a ConfigNode from a given object. This function will use reflection to scan the given object
    /// looking for fields with the [Persistent] attribute. When it finds such a field 
    /// it adds it as a name-value pair to the returned ConfigNode. The name wil be the name
    /// of the field, and the value will the the serialized version of the field's data.
    /// </summary>
    /// <param name="obj">The object to scan to create a ConfigNode</param>
    /// <returns>A ConfigNode containing the persistent fields of the object.</returns>
    public extern static ConfigNode CreateConfigFromObject(object obj);
    /// <summary>
    /// Like CreateConfigFromObject, but only pays attention to fields with the "pass"
    /// field of the [Persistent] attribute set to pass.
    /// </summary>
    /// <param name="obj">The object to scan to create a ConfigNode.</param>
    /// <param name="pass">A flag indicate which fields to serialize.</param>
    /// <returns>A ConfigNode containing the desired persistent fields of the object.</returns>
    public extern static ConfigNode CreateConfigFromObject(object obj, int pass);
    public extern static object CreateObjectFromConfig(ConfigNode node);
    public extern static T CreateObjectFromConfig<T>(ConfigNode node);
    public extern static object CreateObjectFromConfig(string typeName, ConfigNode node);
    public extern ConfigNode GetNode(string name);
    public extern ConfigNode[] GetNodes(string name);
    public extern string GetValue(string name);
    public extern string[] GetValues(string name);
    public extern bool HasNode();
    public extern bool HasNode(string name);
    public extern bool HasValue();
    public extern bool HasValue(string name);
    public extern static ConfigNode Load(string fileFullName);
    /// <summary>
    /// Initialize an existing object using data from the ConfigNode. This method
    /// will scan the object looking for fields with the [Persistent] attribute. When it
    /// finds such a field, it looks in the ConfigNode for a matching name-value pair, and then
    /// parses the value and sets the field to the result.
    /// </summary>
    /// <param name="obj">The object to initialize</param>
    /// <param name="node">The ConfigNode used to initialize the object.</param>
    /// <returns></returns>
    public extern static bool LoadObjectFromConfig(object obj, ConfigNode node);
    /// <summary>
    /// Like LoadObjectFromConfig, but only pays attention to fields for which the "pass"
    /// field of the [Persistent] attribute is equal to pass.
    /// </summary>
    /// <param name="obj">The object to initialize</param>
    /// <param name="node">The ConfigNode used to initialize the object.</param>
    /// <param name="pass">A flag indicating which fields to initialize.</param>
    /// <returns></returns>
    public extern static bool LoadObjectFromConfig(object obj, ConfigNode node, int pass);
    public extern static Color ParseColor(string vectorString);
    public extern static Color32 ParseColor32(string vectorString);
    public extern static Enum ParseEnum(Type enumType, string vectorString);
    public extern static Matrix4x4 ParseMatrix4x4(string quaternionString);
    public extern static Quaternion ParseQuaternion(string quaternionString);
    public extern static QuaternionD ParseQuaternionD(string quaternionString);
    public extern static Vector3 ParseVector2(string vectorString);
    public extern static Vector3 ParseVector3(string vectorString);
    public extern static Vector3d ParseVector3D(string vectorString);
    public extern static Vector4 ParseVector4(string vectorString);
    /// <summary>
    /// Seralize this ConfigNode to a file.
    /// </summary>
    /// <param name="fileFullName">A filename (absolute path?)</param>
    /// <returns>?</returns>
    public extern bool Save(string fileFullName);
    public extern bool Save(string fileFullName, string header);
    public extern bool SetNode(string name, ConfigNode newNode);
    public extern bool SetNode(string name, ConfigNode newNode, int index);
    public extern bool SetValue(string name, string newValue);
    public extern bool SetValue(string name, string newValue, int index);
    /// <summary>
    /// Seralizes this ConfigNode to a string.
    /// </summary>
    /// <returns>A serialized version of this ConfigNode</returns>
    public extern override string ToString();
    public extern static string WriteColor(Color color);
    public extern static string WriteColor(Color32 color);
    public extern static string WriteEnum(Enum en);
    public extern static string WriteMatrix4x4(Matrix4x4 matrix);
    public extern static string WriteQuaternion(Quaternion quaternion);
    public extern static string WriteQuaternion(QuaternionD quaternion);
    public extern static string WriteVector(Vector2 vector);
    public extern static string WriteVector(Vector3 vector);
    public extern static string WriteVector(Vector3d vector);
    public extern static string WriteVector(Vector4 vector);

    [Serializable]
    public class ConfigNodeList : IEnumerable
    {
        public extern ConfigNodeList();

        public extern int Count { get; }

        public extern void Add(ConfigNode n);
        public extern void Clear();
        public extern bool Contains(string name);
        public extern IEnumerator GetEnumerator();
        public extern ConfigNode GetNode(string name);
        public extern ConfigNode[] GetNodes(string name);
        public extern bool SetNode(string name, ConfigNode newNode);
        public extern bool SetNode(string name, ConfigNode newNode, int index);
    }

    [Serializable]
    public class Value
    {
        public string name;
        public string value;

        public extern Value(string name, string value);
    }

    [Serializable]
    public class ValueList : IEnumerable
    {
        public extern ValueList();

        public extern int Count { get; }

        public extern ConfigNode.Value this[int index] { get; }

        public extern void Add(ConfigNode.Value v);
        public extern void Clear();
        public extern bool Contains(string name);
        public extern IEnumerator GetEnumerator();
        public extern string GetValue(string name);
        public extern string[] GetValues(string name);
        public extern bool SetValue(string name, string newValue);
        public extern bool SetValue(string name, string newValue, int index);
    }
}
