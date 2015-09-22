using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	[SerializeField]
	private float movementSpeed;

	[SerializeField]
	private AudioClip pickupSound;
	[SerializeField]
	private AudioClip hitSound;
	[SerializeField]
	private AudioClip wooshSound;

	private Renderer rend;
	private int countHealth;
	[SerializeField]
	private Score score;

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
		/*
		switch (other.transform.tag) {
		case "RedWall":

				break;
		default:
			break;
		}
		*/
		if (other.transform.tag == "RedWall")
		{
			if(rend.material.color != Color.red) {
				AudioSource.PlayClipAtPoint(hitSound, new Vector3(5, 1, 2));
				countHealth --;
			}
			else{
				AudioSource.PlayClipAtPoint(wooshSound, new Vector3(5, 1, 2));
			}
		}
		else if (other.transform.tag == "GreenWall")
		{
			if(rend.material.color != Color.green){
				AudioSource.PlayClipAtPoint(hitSound, new Vector3(5, 1, 2));
				countHealth --;
			}
			else{
				AudioSource.PlayClipAtPoint(wooshSound, new Vector3(5, 1, 2));
			}
		}
		else if (other.transform.tag == "BlueWall")
		{
			if(rend.material.color != Color.blue){
				AudioSource.PlayClipAtPoint(hitSound, new Vector3(5, 1, 2));
				countHealth--;
			}
			else{
				AudioSource.PlayClipAtPoint(wooshSound, new Vector3(5, 1, 2));
			}
		}
		else if (other.transform.tag == "RedSlime")
		{
			if(rend.material.color == Color.red){
				AudioSource.PlayClipAtPoint(pickupSound, new Vector3(5, 1, 2));
				score.AddScore10();
				Destroy(other.gameObject);
			}

		}
		else if (other.transform.tag == "GreenSlime")
		{
			if(rend.material.color == Color.green){
				AudioSource.PlayClipAtPoint(pickupSound, new Vector3(5, 1, 2));
				score.AddScore10();
				Destroy(other.gameObject);
			}
		}
		else if (other.transform.tag == "BlueSlime")
		{
			if(rend.material.color == Color.blue){
				AudioSource.PlayClipAtPoint(pickupSound, new Vector3(5, 1, 2));
				score.AddScore10();
				Destroy(other.gameObject);
			}
		}
	}
}