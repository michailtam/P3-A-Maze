using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScore : MonoBehaviour {

	public Canvas ui;

	private int score = 0;
	private Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = ui.GetComponentInChildren<Text> ();
		scoreText.text = "Coins: 0/24";
	}

	// Update score when a coin was collected
	public void SetScore() {
		score++;	// Add one coin to score
		scoreText.text = "Coins: " + score + "/24";
	}
}
