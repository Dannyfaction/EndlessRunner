using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallSpawner : MonoBehaviour {

	public List<GameObject> myPrefabs = new List<GameObject>();
	public int counter = 0;

	void Start () {
		
	}
	void redWallSpawner(){
		GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[0], new Vector3(15,0,0), transform.rotation);
	}
	void greenWallSpawner(){
		GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[1], new Vector3(15,0,0), transform.rotation);
	}
	void blueWallSpawner(){
		GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[2], new Vector3(15,0,0), transform.rotation);
	}

	void Update () {

	}
}
