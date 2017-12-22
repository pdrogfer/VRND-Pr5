using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsColor : MonoBehaviour {

	private Renderer renderer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void setWallsYellow() {

		renderer = GetComponent<Renderer> ();

		renderer.material.color = Color.yellow;
	}

	public void setWallsGreen() {

		renderer = GetComponent<Renderer> ();

		renderer.material.color = Color.green;
	}

	public void setWallsWhite() {

		renderer = GetComponent<Renderer> ();

		renderer.material.color = Color.white;
	}
}
