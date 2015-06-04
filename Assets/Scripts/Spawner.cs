using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	private Sprite tmp;
	public GameObject[] Squares;
	public Object[] Line;
	public int amount =10;
	int current;
	ScoreKeeper score;
	public Text keeper;

	void Start () {

		current = amount - 1;

		Squares = new GameObject[4];
		Line = new Object[amount];
		score = new ScoreKeeper();


		Squares[0]= Resources.Load ("BoxRed")as GameObject;
		Squares[1]= Resources.Load ("BoxBlue")as GameObject;
		Squares[2]= Resources.Load ("BoxYellow")as GameObject;
		Squares[3]= Resources.Load ("BoxGreen")as GameObject;




		InvokeRepeating ("SpawnSquare", 1.0f, .5f);

	
	}

	void SpawnSquare ()
	{
		amount --;
		if (amount == 0)
			CancelInvoke ("SpawnSquare");


		int random = Random.Range(0,4);

		Line[amount] = Instantiate(Squares[random], new Vector2(this.transform.position.x,this.transform.position.y),Quaternion.identity);
		Debug.Log (Line[amount].name+"\n");

	}

	public void DeleteFirstYellow ()
	{
		deleteFirst(2);
	}
	public void DeleteFirstBlue ()
	{
		deleteFirst(1);
	}
	public void DeleteFirstGreen ()
	{
		deleteFirst(3);
	}

	public void DeleteFirstRed ()
	{
		deleteFirst(0);
	}

	private void deleteFirst(int color)
	{
		Debug.Log ("current  "+current );
		Debug.Log (Line [current].name +"    LINE");
		Debug.Log (Squares [color].name+"    SQUARES");
		if (Line [current].name.Equals (Squares [color].name + "(Clone)")) {

			Debug.Log ("Colors matched " + Squares [color].name);
			Destroy (Line [current]);
			Line [current] = null;
			current--;
			score.ScoreAdd (1, keeper);
		
		} else {
			score.ScoreAdd(-3,keeper);
		}


			



	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
