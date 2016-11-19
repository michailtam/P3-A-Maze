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
			// User collects the key (hasKey at UserBehaviour script set to true)
			Camera.main.GetComponent<UserBehaviour> ().TakeKey ();

			// Show that key was collected by the user
			GameObject.Find ("GameStats").GetComponent<GameScore>().SetKeyCollected();	

			// Destroy the key. Check the Unity documentation on how to use Destroy
			AudioSource.PlayClipAtPoint (audioClip, transform.position);

			// Create glow effect by destroying key
			ParticleSystem glow = (ParticleSystem)Instantiate(keyEffect, transform.position, Quaternion.Euler(-90f,0f,0f));

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
