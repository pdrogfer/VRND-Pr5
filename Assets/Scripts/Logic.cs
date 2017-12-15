using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {

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

		player.transform.position = wp1.transform.position;
	}
}
