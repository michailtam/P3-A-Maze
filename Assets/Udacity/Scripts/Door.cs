using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public GameObject keyObject;

	private Color defautlDoorColor;

    // Create a boolean value called "locked" that can be checked in Update() 
	private bool locked = true;

	void Start() {
		defautlDoorColor = GetComponent<Renderer> ().material.color;
	}

    void Update() {
        // If the door is unlocked and it is not fully raised
        // Animate the door raising up

    }

    public void Unlock()
    {
		keyObject.GetComponent<AudioSource>().Play ();

        // You'll need to set "locked" to true here
		if (locked) {
			// open door
		}
    }

	public void OnPointerEnter() {
		if (locked) {
			GetComponent<Renderer> ().material.color = Color.red;
		} else {
			GetComponent<Renderer> ().material.color = Color.green;
		}
	}

	public void OnPointerExit() {
		GetComponent<Renderer> ().material.color = defautlDoorColor;
	}
}
