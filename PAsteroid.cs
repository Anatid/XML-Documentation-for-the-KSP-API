/// <summary>Stores information on an asteroid's shape</summary>
public class PAsteroid : MonoBehaviour
{
	/// <summary>The largest distance of any vertex to the mesh center</summary>
	public float highestPoint;

	/// <summary>The (approximate?) volume of the asteroid mesh</summary>
	public float volume;

	//----------------------------------------------------------------------

	/// <summary>Combines premade elements into visual, collider, and convex meshes.</summary>
	public void Setup (Mesh visualMesh, Material visualMaterial, string visualLayer, string visualTag, 
		Mesh colliderMesh, PhysicMaterial colliderMaterial, string colliderLayer, string colliderTag, 
		Mesh convexMesh, PhysicMaterial convexMaterial, string convexLayer, string convexTag);
}
