using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int money = 25;
	public int bombom = 10;
	public int bala = 20;
	public int doce = 2;

	public Text playerText;

	void setPlayerText(){
		playerText.text = "Dinheiros: " + money.ToString() + " Balas: " + bala.ToString();
	}
	
	void Start () {
		setPlayerText();
	}
	
	// Update is called once per frame
	void Update () {
		setPlayerText();
		if(money == 0)
			Application.LoadLevel("Entrega");
	}
}
