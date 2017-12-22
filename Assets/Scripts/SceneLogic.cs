using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is my own simple script based on what I have learned. It provides a simple forward/backward navigation
// system, plus other utility functions.
public class SceneLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject sunLight;

	public GameObject wallsMaterial;
	public Renderer renderer;

	public GameObject[] panelsUI = new GameObject[6];
	public GameObject[] playerWaypoints = new GameObject[6];
	private GameObject presentUI;
	private GameObject presentWaypoint;

	private Quaternion currentRotation;
	private Quaternion targetRotation;

	private int positionIndex;

	// Use this for initialization
	void Start () {

		player = player.transform.parent.gameObject;

		positionIndex = 0;

		// presentWaypoint = playerWaypoints [positionIndex];
		player.transform.position = playerWaypoints [positionIndex].transform.position;// presentWaypoint.transform.position;

		currentRotation = sunLight.transform.rotation;
		targetRotation = sunLight.transform.rotation;
	}

	// Update is called once per frame
	void Update () {

		UpdatePanels ();

		UpdateLight ();
	}

	public void MoveForward () {

		positionIndex++;

		MovePlayer ();
	}

	public void MoveBackward () {

		positionIndex--;

		MovePlayer ();
	}

	public void MoveRestart() {

		positionIndex = 0;

		player.transform.position = playerWaypoints [positionIndex].transform.position;
	}

	private void MovePlayer() {

		iTween.MoveTo (player,
			iTween.Hash (
				"position", playerWaypoints[positionIndex].transform.position,
				"time", 2, 
				"easetype", "linear"
			)
		);
	}

	private void UpdatePanels() {

		for (int i = 0; i < panelsUI.Length; i++) {

			if(i == positionIndex) {

				panelsUI [i].SetActive (true);
			} 
			else {

				panelsUI [i].SetActive (false);
			}
		}
	}

	private void UpdateLight() {

		currentRotation = Quaternion.RotateTowards (sunLight.transform.rotation, targetRotation, Time.deltaTime);

		sunLight.transform.rotation = currentRotation;
	}
		
	public void sunLightForward() {

		iTween.RotateTo (sunLight, iTween.Hash ("y", sunLight.transform.rotation.eulerAngles.y + 30, "easetype", iTween.EaseType.easeInOutSine));
		iTween.RotateTo (sunLight, iTween.Hash ("x", sunLight.transform.rotation.eulerAngles.x + 10, "easetype", iTween.EaseType.easeInOutSine));
	}

	public void sunLightBackward() {

		iTween.RotateTo (sunLight, iTween.Hash ("y", sunLight.transform.rotation.eulerAngles.y - 30, "easetype", iTween.EaseType.easeInOutSine));
		iTween.RotateTo (sunLight, iTween.Hash ("x", sunLight.transform.rotation.eulerAngles.x - 10, "easetype", iTween.EaseType.easeInOutSine));
	}

}
