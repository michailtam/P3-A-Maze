using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyObject;
	public GameObject doorObject;

	void Start() {
		// Set the animation speed to 0.3
		Animator keyAnimator = gameObject.GetComponent<Animator> ();
		keyAnimator.speed = 0.3f;	

		// Set the key color to magenta
		Renderer objectRenderer = gameObject.GetComponentInChildren<Renderer> ();
		objectRenderer.material.color = Color.magenta;
	}	

	void Update()
	{
		//Bonus: Key Animation
	}
		
	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Debug.Log("Key was clicked");
	}
}
