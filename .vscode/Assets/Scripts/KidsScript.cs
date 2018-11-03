using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KidsScript : MonoBehaviour {
	public GameObject BTM;

	public Rodadas rounds;

	public Sprite k1;
	public Sprite k2;
	public Sprite k3;
	public Sprite k4;
	public Sprite k5;
	public Sprite k6;
	public Sprite k7;
	public Sprite k8;

	public int humor;
	public float qntAtual;
	public float qntNec;
	public int condicional;
	public int whichSprite;

	public void gerarKid(int x){
		if(x <= 5) { humor = Random.Range(1,3); } 
		else if (x > 5 && x < 10) { humor = Random.Range(1,4); } 
		else if (x > 10) { humor = Random.Range(2,4);}
		qntAtual = 0;

		whichSprite = Random.Range(1,9);

		if(whichSprite == 1) this.GetComponent<Image>().sprite = k1;
		else if(whichSprite == 2) this.GetComponent<Image>().sprite = k2;
		else if(whichSprite == 3) this.GetComponent<Image>().sprite = k3;
		else if(whichSprite == 4) this.GetComponent<Image>().sprite = k4;
		else if(whichSprite == 5) this.GetComponent<Image>().sprite = k5;
		else if(whichSprite == 6) this.GetComponent<Image>().sprite = k6;
		else if(whichSprite == 7) this.GetComponent<Image>().sprite = k7;
		else if(whichSprite == 8) this.GetComponent<Image>().sprite = k8;
		
		if(humor==1) qntNec=5;
		else if(humor==2) qntNec=10;
		else if(humor==3) qntNec=15;

	}

	void Start () {
		gerarKid(1);
	}

	public void OnClick(){
		BTM.SetActive(true);
	}

	
	// Update is called once per frame
	void Update () {
	}
}
