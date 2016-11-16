using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public GameObject keyObject;
	public AudioClip[] audioClips;
	public AudioSource audioSource;

	private Color defautlDoorColor;

    // Create a boolean value called "locked" that can be checked in Update() 
	private bool locked = true;

	void Start() {
		// Save the default door color
		defautlDoorColor = GetComponent<Renderer> ().material.color;

		// Stop the animation at startup and set animation speed
		gameObject.transform.parent.GetComponent<Animator>().speed = 0.5f;
	}

    void Update() {
        // If the door is unlocked and it is not fully raised. Animate the door raising up
		// Check if door has unlocked and then play the animation open door
		if(!audioSource.isPlaying && !locked) {	
			gameObject.transform.parent.GetComponent<Animator> ().SetTrigger ("open");	// Play open door animation	
		}
    }

    public void Unlock()
    {
		//keyObject.GetComponent<AudioSource>().Play ();

		// Check if the user has the key found and collected
		UserBehaviour user = Camera.main.GetComponent<UserBehaviour>();
		if (user.GetKey ()) {
			// open door
			audioSource.clip = audioClips [0];	
			audioSource.Play ();	// Play audio clip when door is unlocked
			locked = false;
			GetComponent<Renderer> ().material.color = defautlDoorColor;
		} else {
			audioSource.clip = audioClips [1];	
			audioSource.Play ();	// Play audio clip when door is locked
		}
    }

	private void OpenDoor() {
		
	}

	public void OnEnterDoor() {
		GetComponent<Renderer> ().material.color = Color.yellow;
	}

	public void OnExitDoor() {
		GetComponent<Renderer> ().material.color = defautlDoorColor;
	}
}
