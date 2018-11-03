using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonScript : MonoBehaviour {

	public KidsScript kI;
	public int count;

	public Sprite image1;
	public Sprite image2;
	public Sprite image3;

	void Start () {
		
	}
	
	void Update () {
		if(kI.qntAtual < kI.qntNec){
			if(kI.humor == 1)
			this.GetComponent<SpriteRenderer>().sprite = image1;
			else if(kI.humor == 2)
			this.GetComponent<SpriteRenderer>().sprite = image2;
			else if(kI.humor == 3)
			this.GetComponent<SpriteRenderer>().sprite = image3;
		}
		if(kI.qntAtual < kI.qntNec){
			this.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
