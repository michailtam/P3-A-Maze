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
        // Instatiate the KeyPoof Prefab where this key is located
        
		// Call the Unlock() method on the Door
		doorObject.Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		//Destroy (gameObject, 2);
	}
		
	public void OnPointerEnter() {
		GetComponent<Renderer> ().material.color = Color.green;	// Set key color when mouse hovers over
	}

	public void OnPointerExit() {
		GetComponent<Renderer> ().material.color = Color.magenta;	// Set color back to magenta when mouse is not hovered over
	}
}
