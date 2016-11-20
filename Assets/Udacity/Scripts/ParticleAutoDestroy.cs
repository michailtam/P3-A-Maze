using UnityEngine;
using System.Collections;

public class ParticleAutoDestroy : MonoBehaviour {

	void Start () {
		Destroy (gameObject, 2.0f);		// Auto destroy particle system object after 2 seconds
	}
}
