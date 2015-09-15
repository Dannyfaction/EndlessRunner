using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text ScoreText;
	public int totalScore;
	
	public void Start()
	{
		totalScore = 0;
		UpdateUI();
	}
	
	public void AddScore10()
	{
		totalScore += 10;
		UpdateUI ();
	}
	
	void UpdateUI()
	{
		ScoreText.text = "Score: " + totalScore;
	}
}

