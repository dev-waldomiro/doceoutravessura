using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidsScript : MonoBehaviour {

	Random rnd = new System.Random();

	void startGiving (Input.KeyDown("enter")){

		int persona = rnd.Next(1, 4);
		int indexNo = rnd.Next(1, 14);
		int sprite = rnd.Next(1, 14);

	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
