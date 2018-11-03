using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int money = 25;
	public int bombom = 0;
	public int bala = 0;
	public int cupck = 0;

	public Text playerText;

	void setPlayerText(){
		playerText.text = "Dinheiros: " + money.ToString() + " \nBalas: " + bala.ToString() + " \nBombons: " + bombom.ToString() + " \nCupcakes: " + cupck.ToString() ;
	}
	
	void Start () {
		setPlayerText();
	}
	
	// Update is called once per frame
	void Update () {
		setPlayerText();
		if(money == 0)
			Application.LoadLevel("Entrega");

		PlayerPrefs.SetInt("bombom", bombom);
		PlayerPrefs.SetInt("bala", bala);
		PlayerPrefs.SetInt("cupck", cupck);
	}
}
