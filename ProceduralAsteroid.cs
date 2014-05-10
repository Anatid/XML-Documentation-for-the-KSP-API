/// <summary>Generates an asteroid shape</summary>
public class ProceduralAsteroid : MonoBehaviour
{
	/// <summary>The desired reference surface of the asteroid mesh</summary>
	[SerializeField] public float radius;

	//----------------------------------------------------------------------

	/// <summary>Initializes a randomly generated asteroid shape</summary>
	///
	/// <remarks>
	/// <param name='seed'>Used to randomize the mesh</param>
	/// <param name='radius'>The desired reference surface of the asteroid mesh</param>
	/// <param name='parent'>The reference frame in which the asteroid is to be oriented</param>
	///
	/// Note: <paramref name="parent"/> may not be null, even though UnityEngine.Transforms 
	///	are usually allowed to have null parents.
	///
	/// <returns>An object containing all relevant meshes and key statistics</returns>
	/// </remarks>
	public PAsteroid Generate (int seed, float radius, Transform parent);

	//----------------------------------------------------------------------

	[Serializable] public class ModValue {
		public string name;

		/// <summary>Smallest mesh height that can be randomly chosen, in units of the asteroid radius</summary>
		public float minValue;

		/// <summary>Largest mesh height that can be randomly chosen, in units of the asteroid radius</summary>
		public float maxValue;

		/// <summary>Size multiplier in addition to ProceduralAsteroid.radius</summary>
		public float radiusFactor;
	}

	[Serializable] public class ModWrapper {
		public string name = "";

		public ProceduralAsteroid.ModValue[] values;

		public PQSMod mod {
			get;
			set;
		}
	}
}
