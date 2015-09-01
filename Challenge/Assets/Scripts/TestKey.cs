using UnityEngine;
using System.Collections;

public class TestKey: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape"))
			Application.LoadLevel ("MainMenu");
	}
}
