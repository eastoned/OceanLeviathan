using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dankWaterbob : MonoBehaviour {

	public float time; // the duration of each animation
	public float high;


	// Use this for initialization
	void Start () {
		iTween.MoveBy (this.gameObject, iTween.Hash ("y", high, "time", time, "looptype", "pingpong", "easetype", iTween.EaseType.easeInOutSine));
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
