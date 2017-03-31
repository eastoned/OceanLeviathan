using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dankWaterbob : MonoBehaviour {

	public float time; // the duration of each animation
	public float high;


	// Use this for initialization
	void Start () {
		iTween.MoveBy (this.gameObject, iTween.Hash ("y", high, "time", time, "looptype", "pingpong", "easetype", iTween.EaseType.easeInOutSine));


		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;

		// create new colors array where the colors will be created.
		Color[] colors = new Color[vertices.Length];
		for (int i = 0; i < vertices.Length; i++)
			colors[i] = Color.Lerp(Color.red, Color.green, vertices[i].y);

		// assign the array of colors to the Mesh.
		mesh.colors = colors;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

