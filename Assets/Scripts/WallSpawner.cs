using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WallSpawner : MonoBehaviour {

	[SerializeField]
	private List<GameObject> myPrefabs = new List<GameObject>();
	private float wallSpawnTimer = 10f;
	private float whichColor = 0f;
	private float whichSlime = 0f;
	private float slimeSpawner = 0f;

	void Start () {
		
	}
	void redWallSpawner(){
		//Spawn Red Wall
		GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[0], new Vector3(15,0,0), transform.rotation);
	}
	void greenWallSpawner(){
		//Spawn Green Wall
		GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[1], new Vector3(15,0,0), transform.rotation);
	}
	void blueWallSpawner(){
		//Spawn Blue Wall
		GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[2], new Vector3(15,0,0), transform.rotation);
	}

	void Update () {
		wallSpawnTimer -= Time.deltaTime * 10;
		if(wallSpawnTimer <= 0){
			wallSpawnTimer = Random.Range(5,20);
			whichColor = Random.Range(1,4);
			whichSlime = Random.Range(1,4);
			slimeSpawner = Random.Range(0,10);
			if(slimeSpawner <= 5){
				if(Mathf.Round(whichSlime) == 1){
					//Spawn Red Slime
					GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[3], new Vector3(20,Random.Range(-4,4),0), transform.rotation);
				}
				else if(Mathf.Round(whichSlime) == 2){
					//Spawn Red Slime
					GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[4], new Vector3(20,Random.Range(-4,4),0), transform.rotation);
				}
				else if(Mathf.Round(whichSlime) == 3){
					//Spawn Red Slime
					GameObject wallSpawn = (GameObject)Instantiate(myPrefabs[5], new Vector3(20,Random.Range(-4,4),0), transform.rotation);
				}
			}
			if(Mathf.Round(whichColor)== 1){
				redWallSpawner();
			}
			else if(Mathf.Round(whichColor)== 2){
				greenWallSpawner();
			}
			else if(Mathf.Round(whichColor)== 3){
				blueWallSpawner();
			}
		}
	}
}
