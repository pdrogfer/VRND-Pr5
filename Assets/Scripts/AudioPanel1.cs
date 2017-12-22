using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPanel1 : MonoBehaviour {

	public AudioClip audio_1;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {

		audioSource = gameObject.GetComponent<AudioSource> ();
//		audioSource.clip = audio_1;
//		audioSource.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void playAudio1() {

		audioSource.Play();
	}
}
