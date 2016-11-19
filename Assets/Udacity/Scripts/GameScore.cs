using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScore : MonoBehaviour {

	public Canvas ui;

	private const float DELAY = 2.0f;	// Delay time for showing score
	private int score = 0;		// Initial score
	private Text scoreField;

	// Use this for initialization
	void Start () {
		scoreField = ui.GetComponentInChildren<Text> ();
		scoreField.text = "Coins: 0/24";

		// Show the user how many coins he can collect and that he needs a key to open the gate
		StartCoroutine (KeyCollectionDelay());
	}

	// Update score when a coin was collected
	public void SetScore() {
		scoreField.enabled = true;
		score++;	// Add one coin to score
		scoreField.text = "Coins: " + score + "/24";
		StartCoroutine (ScoreDelay());
	}

	// Show user that he has collected the key
	public void SetKeyCollected() {
		scoreField.enabled = true;
		StartCoroutine (KeyCollectionDelay());
	}

	// Show score for 3 seconds
	IEnumerator ScoreDelay () {
		yield return new WaitForSeconds(DELAY);	// Show score for 3 seconds
		scoreField.enabled = false;
	}

	// Show key collection status for 3 seconds
	IEnumerator KeyCollectionDelay () {

		// Show if the user has the key or not
		if (!Camera.main.GetComponent<UserBehaviour> ().GetKey ()) {
			scoreField.text = "Coins: " + score + "/24" + "     Key: NO";
		} else {
			scoreField.text = "Coins: " + score + "/24" + "     Key: YES";
		}

		yield return new WaitForSeconds(3.0f);	// Show score for 3 seconds
		scoreField.enabled = false;
		scoreField.text = "Coins: " + score + "/24";	// Show only the the coins 
	}
}
