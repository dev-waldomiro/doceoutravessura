using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CandyButton : MonoBehaviour {


	public float valor;
	public KidsScript add;
	public KidsScript add1;

	public int qnt;

	public bool bombom;
	public bool bala;
	public bool cupck;

	public void Choose(){
		add=GameObject.FindWithTag("button").GetComponent<KidsScript>();
		add1=GameObject.FindWithTag("button1").GetComponent<KidsScript>();

		if(add.qntAtual >= add.qntNec){
		add=GameObject.FindWithTag("button1").GetComponent<KidsScript>();
		add1=GameObject.FindWithTag("button2").GetComponent<KidsScript>();
		}
		if(add1.qntAtual < add1.qntNec && add.qntAtual >= add.qntNec) add=GameObject.FindWithTag("button2").GetComponent<KidsScript>();
	}

	public void addValor(){
		if(add.qntAtual < add.qntNec && qnt > 0){
			add.qntAtual = add.qntAtual + valor;
			qnt--;
		}
		else if(add.qntAtual >= add.qntNec || qnt == 0)
			return;
	}

	// Use this for initialization
	void Start () {
		if(bombom) qnt = PlayerPrefs.GetInt("bombom");
		if(bala) qnt = PlayerPrefs.GetInt("bala");
		if(cupck) qnt = PlayerPrefs.GetInt("cupck");
		Choose();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Choose();
	}
}
