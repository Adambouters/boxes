using UnityEngine;
using System.Collections;

public class SquareMovement : MonoBehaviour {


	public static float speed = .05f;

	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (Vector3.right * speed);
	
	}
}
