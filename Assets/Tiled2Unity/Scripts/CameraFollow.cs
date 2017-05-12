using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	
	public Transform target;
	Camera mycam;
	public float m_speed = 0.1f;

	// Use this for initialization
	void Start () {
		mycam = GetComponent<Camera> ();

	}
	
	// Update is called once per frame
	void Update () {
		// orthographicSize correlates to "size" in camera
		// f just makes it a float, so it's 100.0
		// ensures game scale is the same across devices
		mycam.orthographicSize = (Screen.height / 100f) / 5f;

		if(target){
			transform.position = Vector3.Lerp(transform.position, target.position + new Vector3(0,-0.5f,-10), m_speed);
		}
	}
}
