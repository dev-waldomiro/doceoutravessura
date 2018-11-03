using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUDIOLAST : MonoBehaviour {

	public AudioClip audio1;
	public AudioClip audio2;
	public AudioClip audio3;
	public AudioClip audio4;

	public AudioSource asour;
	public int audio;

	// Use this for initialization
	void Start () {
		audio = PlayerPrefs.GetInt("final");
		asour = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(audio == 1) asour.clip = audio1;
		if(audio == 2) asour.clip = audio2;
		if(audio == 3) asour.clip = audio3;
		if(audio == 4) asour.clip = audio4;
		asour.Play();
		
	}
}
