using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScore : MonoBehaviour {

	public Canvas ui;

	private const float DELAY = 3.0f;	// Delay time for showing score
	private int score = 0;		// Initial score
	private Text scoreField;

	// Use this for initialization
	void Start () {
		scoreField = ui.GetComponentInChildren<Text> ();
		scoreField.text = "Coins: 0/24";
		StartCoroutine (ShowScore ());
	}

	// Update score when a coin was collected
	public void SetScore() {
		scoreField.enabled = true;
		score++;	// Add one coin to score
		scoreField.text = "Coins: " + score + "/24";
		StartCoroutine (ShowScore());
	}

	IEnumerator ShowScore () {
		yield return new WaitForSeconds(DELAY);	// Show score for 3 seconds
		scoreField.enabled = false;
	}
}
