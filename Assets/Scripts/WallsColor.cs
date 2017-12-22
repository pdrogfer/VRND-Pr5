using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsColor : MonoBehaviour {

	public Renderer renderer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void setWallsYellow() {

		renderer = GetComponent<Renderer> ();

		renderer.material.color = Color.yellow;

		//Color[] palette = new Color[] { Color.yellow };
		//wallsMaterial.SetColor ("_SpecColor", Color.yellow);// = Color.yellow;
	}
}
