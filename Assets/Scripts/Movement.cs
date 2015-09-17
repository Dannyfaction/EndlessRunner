using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float movementSpeed;
	private Renderer rend;
	public int countHealth;
	public Score score;

	void Start () {
		countHealth = 5;
		rend = GetComponent<Renderer>();
	}

	void Update () {
		float y = Input.GetAxis ("Move") * 2;
		Vector2 movement = new Vector2 (0f, y);
		transform.Translate (movement * movementSpeed * Time.deltaTime);

		if (Input.GetKeyDown ("1")) {
			rend.material.color = Color.red;
		}
		if (Input.GetKeyDown ("2")) {
			rend.material.color = Color.green;
		}
		if (Input.GetKeyDown ("3")) {
			rend.material.color = Color.blue;
		}

		switch (countHealth) {
		case 4:	Destroy(GameObject.Find("Heart1"));
			break;
		case 3: Destroy(GameObject.Find("Heart2"));
			break;
		case 2: Destroy(GameObject.Find("Heart3"));
			break;
		case 1: Destroy(GameObject.Find("Heart4"));
			break;
		case 0: Destroy(GameObject.Find("Heart5"));
			Application.LoadLevel("End");
			break;
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "RedWall")
		{
			if(rend.material.color != Color.red) {
				countHealth --;
			}
		}
		else if (other.transform.tag == "GreenWall")
		{
			if(rend.material.color != Color.green){
				countHealth --;
			}
		}
		else if (other.transform.tag == "BlueWall")
		{
			if(rend.material.color != Color.blue){
				countHealth--;
			}
		}
		else if (other.transform.tag == "RedSlime")
		{
			if(rend.material.color == Color.red){
				score.AddScore10();
				Destroy(other.gameObject);
			}

		}
		else if (other.transform.tag == "GreenSlime")
		{
			if(rend.material.color == Color.green){
				score.AddScore10();
				Destroy(other.gameObject);
			}
		}
		else if (other.transform.tag == "BlueSlime")
		{
			if(rend.material.color == Color.blue){
				score.AddScore10();
				Destroy(other.gameObject);
			}
		}
	}
}