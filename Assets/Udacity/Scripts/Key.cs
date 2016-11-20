using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public Key keyObject;
	public Door doorObject;
	public AudioClip audioClip;
	public ParticleSystem keyEffect;

	void Start() {
		// Set the animation speed to 0.3
		Animator keyAnimator = GetComponent<Animator> ();
		keyAnimator.speed = 0.3f;	

		// Set the key color to magenta
		GetComponent<Renderer> ().material.color = Color.magenta;
	}	
		
	public void OnKeyClicked()
	{
		// Check if user stands neer and in front of the key
		float distance = Mathf.Abs(transform.position.x - Camera.main.transform.position.x);
		if (distance <= 10.0f) {
			// Play audio by collecting the key
			AudioSource.PlayClipAtPoint (audioClip, transform.position);
			Camera.main.GetComponent<UserBehaviour> ().TakeKey ();	// Save that the user has collected the key
			GameObject.Find ("GameStats").GetComponent<GameScore>().ShowKeyCollected();	// Show that key was collected by the user

			// Create glow effect when the key gets destroyed (the particle system will be rotated so that the particles emit upwards)
			Instantiate(keyEffect, transform.position, Quaternion.Euler(-90f,0f,0f));

			// Destroy key object immediately
			Destroy (gameObject);
		}
	}
		
	public void OnKeyEnter() {
		// Check if user stands neer and in front of the key
		float distance = Mathf.Abs(transform.position.x - Camera.main.transform.position.x);
		if (distance <= 10.0f) {
			GetComponent<Renderer> ().material.color = Color.green;	// Set key color when mouse hovers over
		}
	}

	public void OnKeyExit() {
		GetComponent<Renderer> ().material.color = Color.magenta;	// Set color back to magenta when mouse is not hovered over
	}
}
