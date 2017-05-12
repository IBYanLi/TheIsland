using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

	public Transform warpTarget;
	public BoxCollider2D warpBox;

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("Object Collided");

		// dumb way to check if x or y matters when warping being the warpBox
		if (warpBox.size.x > warpBox.size.y) {
			//if collide, moves to warp target
			other.gameObject.transform.position = new Vector3 (other.gameObject.transform.position.x, warpTarget.position.y, warpTarget.position.z);
			//move cam too
			Camera.main.transform.position = warpTarget.position;
		} else {
			other.gameObject.transform.position = new Vector3 (warpTarget.position.x, other.gameObject.transform.position.y, warpTarget.position.z);
			Camera.main.transform.position = warpTarget.position;
		}
	}

}
