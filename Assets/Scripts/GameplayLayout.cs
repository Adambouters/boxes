using UnityEngine;
using System.Collections;

//Author: Adam Bouters
//Created 6/03/2015

public class GameplayLayout : MonoBehaviour {
	
	private float screenWidth;
	private float screenHeight;
	GameObject go;
	Spawner Spawn;
	public static RectTransform score;

	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		go = GameObject.Find ("Start");
		Spawn = (Spawner)go.GetComponent (typeof(Spawner));


		if (this.name == "ButtonBlue") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 4);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (RectTransformExtensions.GetWidth(this.GetComponent<RectTransform> ())/2, 
			                                       screenHeight - RectTransformExtensions.GetHeight(this.GetComponent<RectTransform> ()) / 2,
			                                       0);
		} else if (this.name == "ButtonRed") {

			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 4);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			//Debug.Log ("WIDHT RED"+ );
			this.transform.position = new Vector3 (RectTransformExtensions.GetWidth(this.GetComponent<RectTransform> ())/2, 
			                                       RectTransformExtensions.GetHeight(this.GetComponent<RectTransform> ()) / 2, 
			                                       0);
		} else if (this.name == "ButtonYellow") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 4);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth - RectTransformExtensions.GetWidth(this.GetComponent<RectTransform> ())/2,
			                                       screenHeight - RectTransformExtensions.GetHeight(this.GetComponent<RectTransform> ()) / 2,
			                                       0);
		} else if (this.name == "ButtonGreen") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 4);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth - RectTransformExtensions.GetWidth(this.GetComponent<RectTransform> ())/2,
			                                       RectTransformExtensions.GetHeight(this.GetComponent<RectTransform> ()) / 2,
			                                       0);
		}
	}
	
	// Update is called once per frame
	void Update () {




	}
	public void CheckForClick()

	{


		if (this.name == "ButtonGreen") {
			Spawn.DeleteFirstGreen();			
		} else if (this.name == "ButtonYellow") {
			Spawn.DeleteFirstYellow();
		}
		else if (this.name == "ButtonRed") {
			Spawn.DeleteFirstRed();
		}
		else if (this.name == "ButtonBlue"){
			Spawn.DeleteFirstBlue();
		}
	}

}
