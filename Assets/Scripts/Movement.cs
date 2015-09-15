using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float movementSpeed;
	private Renderer rend;
	public int countHealth;
	public Score score;

	void Start () {
		countHealth = 3;
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
		if (countHealth == 2) {
			Destroy(GameObject.Find("Heart1"));
		}
		if (countHealth == 1) {
			Destroy(GameObject.Find("Heart2"));
		}
		if (countHealth == 0) {
			Destroy(GameObject.Find("Heart3"));
			print("You are dead!");
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "Rood")
		{
			if(rend.material.color == Color.red){
				score.AddScore10();
			}
			else {
				countHealth --;
			}
		}
		if (other.transform.tag == "Groen")
		{
			if(rend.material.color == Color.green){
				score.AddScore10();
			}
			else {
				countHealth --;
			}
		}
		if (other.transform.tag == "Blauw")
		{
			if(rend.material.color == Color.blue){
				score.AddScore10();
			}
			else {
				countHealth--;
			}
		}
	}
}