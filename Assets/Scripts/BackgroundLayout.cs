using UnityEngine;
using System.Collections;
//Author: Troy Reynolds
//Created 5/21/2015

public class BackgroundLayout : MonoBehaviour {

	private float screenWidth;
	private float screenHeight;
	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;

		if (this.name == "Blue") {
			this.transform.position = new Vector3 (screenWidth / 4, screenHeight - screenHeight / 4, 0);
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 2);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 2);
		} else if (this.name == "Red") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 2);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 2);
			this.transform.position = new Vector3 (screenWidth / 4, screenHeight / 4, 0);
		} else if (this.name == "Yellow") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 2);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 2);
			this.transform.position = new Vector3 (screenWidth - screenWidth / 4, screenHeight - screenHeight / 4, 0);
		} else if (this.name == "Green") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 2);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 2);
			this.transform.position = new Vector3 (screenWidth - screenWidth / 4, screenHeight / 4, 0);
		} else if (this.name == "Play") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 4, 0);
		} else if (this.name == "PersonalHS") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 2, 0);
		} else if (this.name == "GlobalHS") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 1.33F, 0);
		} else if (this.name == "MainMenu") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 2, 0);
		} else if (this.name == "Score") {

		} else if (this.name == "InputName") {
			//RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 4);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 4, 0);
		} else if (this.name == "SubmitButton") {
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 1.33F, 0);
		} else if (this.name == "SubmitToGlobal") {
			Debug.LogWarning("WE are in submit to global");
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 2, 0);
		}
		else if(this.name =="GlobalMainMenu"){
			RectTransformExtensions.SetHeight (this.GetComponent<RectTransform> (), screenHeight / 6);
			RectTransformExtensions.SetWidth (this.GetComponent<RectTransform> (), screenWidth / 4);
			this.transform.position = new Vector3 (screenWidth / 2, screenHeight - screenHeight / 1.33F, 0);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
