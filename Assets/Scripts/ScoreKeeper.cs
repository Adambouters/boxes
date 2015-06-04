using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {


	public Text score;
	int scorekeeper = 0;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		score.text = "Score: 00000000" ;


	}
	
	// Update is called once per frame
	void Update () {


	}

	public  void ScoreAdd(int num,Text update)
	{

		scorekeeper += num;
	update.text = "Score: " + scorekeeper;
	}


}
