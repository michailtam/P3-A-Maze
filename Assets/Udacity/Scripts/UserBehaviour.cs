using UnityEngine;
using System.Collections;

public class UserBehaviour : MonoBehaviour {

	private bool hasKey = false;	// At startup the user has no key

	// Saves that user has collected the key
	public void TakeKey() {
		hasKey = true;	// User has collected the key 
	}

	// Returns if the user has the key (true) or not
	public bool GetKey() {
		if (hasKey) {
			return true;
		} else {
			return false;
		}
	}
}
