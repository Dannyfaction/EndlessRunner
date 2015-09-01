using UnityEngine;
using System.Collections;
using System;

public class Splash : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
        StartCoroutine("ChangeScreen");
    }

    IEnumerator ChangeScreen()
    {
        //throw new NotImplementedException();
        yield return new WaitForSeconds(1);
        Application.LoadLevel("MainMenu");
    }

    // Update is called once per frame
    void Update () {

	}
}
