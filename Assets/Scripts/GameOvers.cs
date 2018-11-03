using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOvers : MonoBehaviour {

	public Rodadas rounds;
	public CandyButton qnt1;
	public CandyButton qnt2;
	public CandyButton qnt3;

	// Use this for initialization
	void Start () {
		rounds = GameObject.FindWithTag("maisfuckingtag").GetComponent<Rodadas>();
		qnt1 = GameObject.FindWithTag("bala").GetComponent<CandyButton>();
		qnt2 = GameObject.FindWithTag("bombom").GetComponent<CandyButton>();
		qnt3 = GameObject.FindWithTag("cpck").GetComponent<CandyButton>();
	}
	
	// Update is called once per frame
	void Update () {
		if(qnt1.qnt == 0 && qnt2.qnt == 0 && qnt3.qnt == 0 && rounds.rounds < 5){
			PlayerPrefs.SetInt("final", 1);
			SceneManager.LoadScene(3);
		}
		if(qnt1.qnt == 0 && qnt2.qnt == 0 && qnt3.qnt == 0 && rounds.rounds >= 5 && rounds.rounds < 8){
			PlayerPrefs.SetInt("final", 2);
			SceneManager.LoadScene(3);
		}
		if(qnt1.qnt == 0 && qnt2.qnt == 0 && qnt3.qnt == 0 && rounds.rounds >= 8 && rounds.rounds < 12){
			PlayerPrefs.SetInt("final", 3);
			SceneManager.LoadScene(3);
		}
		if(qnt1.qnt == 0 && qnt2.qnt == 0 && qnt3.qnt == 0 && rounds.rounds >= 12){
			PlayerPrefs.SetInt("final", 4);
			SceneManager.LoadScene(3);
		}

	}
}
