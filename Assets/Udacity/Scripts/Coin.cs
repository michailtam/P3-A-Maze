using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour 
{
	public AudioClip audioClip;
	public ParticleSystem coinEffect;

	private GameObject gameStats;	// Game score field

	public void Start() {
		GetComponent<Animator> ().speed = 0.5f;		// Set animation speed to half
		gameStats = GameObject.Find ("GameStats");	// Get the game score object
	}

    public void OnCoinClicked() {
		// Play audio when collected and then destroy the gameobject (coin)
		AudioSource.PlayClipAtPoint(audioClip, transform.position);
		gameStats.GetComponent<GameScore> ().SetScore ();	// Update coins counter (score)

		// Create glow effect by destroying coin
		ParticleSystem glow = (ParticleSystem)Instantiate(coinEffect, transform.position, Quaternion.Euler(-90.0f,0f,0f));


		Destroy (glow, 2);		// Destroy particle object after 2 sec
		Destroy (gameObject);
    }
}
