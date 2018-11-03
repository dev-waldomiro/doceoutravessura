using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverText : MonoBehaviour {

	public Text Text;
	public int sel;
	void Start () {
		sel = PlayerPrefs.GetInt("final");
		if (sel == 1) {
			Text.text += "\nJogaram papel em toda a sua casa ";
		} else if (sel == 2)
			Text.text += "\nPixaram a sua casa ";
		else if (sel == 3)
			Text.tex += "\nQuebraram as suas janelas";
		else if (sel == 4)
			Text.tex += "\nColocaram fogo na sua casa";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
