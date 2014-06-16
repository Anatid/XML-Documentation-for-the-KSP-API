#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// An AttachNode represents the physical connection between a Part and its parent Part.
/// </summary>
[Serializable]
public class AttachNode
{
    /// <summary>
    /// The part attached to this node. Null if no part is attached.
    /// </summary>
    public Part attachedPart;
    public string attachedPartId;
    public AttachNodeMethod attachMethod;
    public float breakingForce;
    public float breakingTorque;
    public GameObject icon;
    public string id;
    /// <summary>
    /// Whether this node is a surface-attach node, a stack node, or a docking node.
    /// </summary>
    public AttachNode.NodeType nodeType;
    public Vector3 offset;
    public Vector3 orientation;
    public Vector3 originalOrientation;
    public Vector3 originalPosition;
    public Vector3 position;
    public float radius;
    public bool requestGate;
    /// <summary>
    /// Wether or not resource cross feed can pass through this node.
    /// </summary>	
	public bool ResourceXFeed;	
    public int size;

    public extern AttachNode();

    public extern void FindAttachedPart();

    public enum NodeType
    {
        /// <summary>
        /// A stack node, like the connections between stacked fuel tanks
        /// </summary>
        Stack = 0,
        /// <summary>
        /// A surface node, like the connection between a radial decoupler and its parent.
        /// </summary>
        Surface = 1,
        /// <summary>
        /// The type of node that connects two docking ports?
        /// </summary>
        Dock = 2,
    }
}
