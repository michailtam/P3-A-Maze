using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public AudioClip audioClip;

	private GameObject gameScore;	// Coins collected

	public void Start() {
		GetComponent<Animator> ().speed = 0.5f;		// Set animation speed to half
		gameScore = GameObject.Find ("GameStats");	// Get the game score object
	}

    public void OnCoinClicked() {
		// Play audio when collected and then destroy the gameobject (coin)
		AudioSource.PlayClipAtPoint(audioClip, transform.position);
		gameScore.GetComponent<GameScore> ().SetScore ();	// Update coins counter (score)
		Destroy (gameObject);
    }
}
