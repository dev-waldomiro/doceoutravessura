using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodadas : MonoBehaviour {

	public KidsScript kidThree;
	public int rounds;

	public KidsScript c1;
	public KidsScript c2;
	public KidsScript c3;

	// Use this for initialization
	void Start () {
		kidThree = GameObject.FindWithTag("button2").GetComponent<KidsScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if(kidThree.qntAtual >= kidThree.qntNec) rounds++;

		if(c1.qntAtual >= c1.qntNec && c2.qntAtual >= c2.qntNec && c3.qntAtual >= c3.qntNec){
			c1.gerarKid(rounds);
			c2.gerarKid(rounds);
			c3.gerarKid(rounds);
		}
	}
}
