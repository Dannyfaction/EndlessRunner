using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

	[SerializeField]
	private Text textScore;
	private int endScore;

	// Use this for initialization
	void Start () {
		endScore = Score.TotalScore;
	}
	
	// Update is called once per frame
	void Update () {
		textScore.text = "Score: " + endScore;
		if (Input.GetKeyDown ("escape")) {
			Application.LoadLevel ("Menu");
		}
	}
}