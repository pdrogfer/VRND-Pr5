﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject presentationUI;
	public GameObject wp0, wp1;

	// Use this for initialization
	void Start () {

		player = player.transform.parent.gameObject;

		player.transform.position = wp0.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	public void ButtonStart () {

		// player.transform.position = wp1.transform.position;

		presentationUI.active = false;

		iTween.MoveTo (player,
			iTween.Hash (
				"position", wp1.transform.position,
				"time", 4, 
				"easetype", "linear"
			)
		);

	}
}
