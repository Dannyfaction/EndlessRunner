using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(Vector2.left * Time.deltaTime * 10);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "RemoveObject")
		{
			Destroy(gameObject);
		}
	}
}
