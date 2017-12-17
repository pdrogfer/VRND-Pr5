using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject[] panelsUI = new GameObject[6];
	public GameObject[] playerWaypoints = new GameObject[6];
	private GameObject presentUI;
	private GameObject presentWaypoint;

	private int positionIndex;

	// Use this for initialization
	void Start () {

		player = player.transform.parent.gameObject;

		positionIndex = 0;

		// UpdatePanels ();

		presentWaypoint = playerWaypoints [positionIndex];
		player.transform.position = presentWaypoint.transform.position;
	}

	// Update is called once per frame
	void Update () {

		UpdatePanels ();
	}

	public void MoveForward () {

		positionIndex++;

		// UpdatePanels ();
		MovePlayer ();
	}

	public void MoveBackward () {

		positionIndex--;

		// UpdatePanels ();
		MovePlayer ();
	}

	private void MovePlayer() {

		iTween.MoveTo (player,
			iTween.Hash (
				"position", playerWaypoints[positionIndex].transform.position,
				"time", 1, 
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
}
