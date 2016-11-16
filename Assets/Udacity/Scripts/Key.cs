using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public Key keyObject;
	public Door doorObject;

	void Start() {
		// Set the animation speed to 0.3
		Animator keyAnimator = GetComponent<Animator> ();
		keyAnimator.speed = 0.3f;	

		// Set the key color to magenta
		GetComponent<Renderer> ().material.color = Color.magenta;
	}	
		
	public void OnKeyClicked()
	{
		// User collects the key (hasKey at UserBehaviour script set to true)
		Camera.main.GetComponent<UserBehaviour>().TakeKey();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject);
	}
		
	public void OnPointerEnter() {
		GetComponent<Renderer> ().material.color = Color.green;	// Set key color when mouse hovers over
	}

	public void OnPointerExit() {
		GetComponent<Renderer> ().material.color = Color.magenta;	// Set color back to magenta when mouse is not hovered over
	}
}
