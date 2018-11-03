using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonScript : MonoBehaviour {

	public KidsScript klI;
	public int count;

	public Sprite image1;
	public Sprite image2;
	public Sprite image3;

	void Start () {
		count = klI.humor;
		
	}
	
	void Update () {
		if(klI.qntAtual < klI.qntNec){
			this.GetComponent<SpriteRenderer>().enabled = true;
			if(klI.humor == 1)
			this.GetComponent<SpriteRenderer>().sprite = image1;
			else if(klI.humor == 2)
			this.GetComponent<SpriteRenderer>().sprite = image2;
			else if(klI.humor == 3)
			this.GetComponent<SpriteRenderer>().sprite = image3;
			

		}
		if(klI.qntAtual >= klI.qntNec){
			this.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
