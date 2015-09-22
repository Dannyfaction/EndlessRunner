using UnityEngine;
using System.Collections;
using System;

public class Splash : MonoBehaviour {
	void Start () {
        StartCoroutine("ChangeScreen");
		transform.position = new Vector3(-35, 1, 0);
    }

    IEnumerator ChangeScreen()
    {
        yield return new WaitForSeconds(4);
        Application.LoadLevel("Menu");
    }
	
    void Update () {
		if(transform.position.x < 0){
			transform.Translate(Vector2.right * Time.deltaTime * 20);
		}
		if(transform.position.x > -1){
			transform.localScale += new Vector3(0.003F, 0.003F, 0);
		}
	}
}
