using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour {

	public int cost;
	public bool bombom = false;
	public bool doce = false;
	public bool bala = false;
	public PlayerScript inventory;

	public void getMoney(){
		if(cost <= inventory.money)
			inventory.money -= cost;

		if(doce && cost <= inventory.money)
			inventory.doce += 1;
		else if (bombom && cost <= inventory.money)
			inventory.bombom += 3;
		else if (bala && cost <= inventory.money)
			inventory.bala += 5;

	}

	// Use this for initialization
	void Awake () {
		inventory = GameObject.FindWithTag("Player").GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
