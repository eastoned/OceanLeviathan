using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncePlane : MonoBehaviour {
	float speed = 1f;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0f,Mathf.PingPong(Time.time*speed, 1), 0f);
	}
}
