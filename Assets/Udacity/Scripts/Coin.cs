using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public AudioClip audioClip;

	public void Start() {
		GetComponent<Animator> ().speed = 0.5f;
	}

    public void OnCoinClicked() {
		// Play audio when collected and then destroy the gameobject (coin)
		AudioSource.PlayClipAtPoint(audioClip, transform.position);
		Destroy (gameObject);
    }
}
