using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

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