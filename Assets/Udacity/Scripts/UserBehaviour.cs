using UnityEngine;
using System.Collections;

public class UserBehaviour : MonoBehaviour {

	private bool hasKey = false;	// At startup the user has no key
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeKey() {
		hasKey = true;	// User has collected the key
		Debug.Log("KEY TAKEN: " + hasKey);
	}

	public bool GetKey() {
		if (hasKey) {
			return true;
		} else {
			return false;
		}
	}
}
