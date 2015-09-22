using UnityEngine;
using System.Collections;
using System;

public class RespawnBg : MonoBehaviour {
	
	[SerializeField]
    private float speed;

	void Update () {
        MoveLeft();
        if (transform.position.x < -40f)
        {
            MoveRigth();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    private void MoveRigth() {
        Vector3 temp = transform.position;
        temp.x = 10f;
        transform.position = temp;
    }
}