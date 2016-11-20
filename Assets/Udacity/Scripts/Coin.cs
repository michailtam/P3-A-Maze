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
		gameStats = GameObject.Find ("GameStats");	// Get the game stats object
	}

    public void OnCoinClicked() {
		// Play audio by collecting coin
		AudioSource.PlayClipAtPoint(audioClip, transform.position);
		gameStats.GetComponent<GameScore> ().SetScore ();	// Update coins counter (score)

		// Create glow effect when the coin gets destroyed (the particle system will be rotated so that the particles emit upwards)
		Instantiate(coinEffect, transform.position, Quaternion.Euler(-90.0f,0f,0f));

		// Destroy coin object immediately
		Destroy (gameObject);
    }
}
