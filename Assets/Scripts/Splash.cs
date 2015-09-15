using UnityEngine;
using System.Collections;
using System;

public class Splash : MonoBehaviour {
//	private Renderer rend;
	// Use this for initialization
	void Start () {
        StartCoroutine("ChangeScreen");
		//rend = GetComponent<Renderer>();
		transform.position = new Vector3(-35, 1, 0);
		//rend.material.color = 0.5;
    }

    IEnumerator ChangeScreen()
    {
        //throw new NotImplementedException();
        yield return new WaitForSeconds(4);
        Application.LoadLevel("Menu");
    }

    // Update is called once per frame
    void Update () {
		if(transform.position.x < 0){
			transform.Translate(Vector2.right * Time.deltaTime * 20);
		}
		if(transform.position.x > -1){
			transform.localScale += new Vector3(0.003F, 0.003F, 0);
		}
	}
}
