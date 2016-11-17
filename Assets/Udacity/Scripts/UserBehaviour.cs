using UnityEngine;
using System.Collections;

public class UserBehaviour : MonoBehaviour {

	private bool hasKey = false;	// At startup the user has no key

	public void TakeKey() {
		hasKey = true;	// User has collected the key
	}

	public bool GetKey() {
		if (hasKey) {
			return true;
		} else {
			return false;
		}
	}
}
