using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	[SerializeField]
	private Text ScoreText;
	public static int totalScore;
	public static int TotalScore{
		get { return totalScore; }
		set { totalScore = value; }
	}
	
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

