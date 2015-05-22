using UnityEngine;
using System.Collections;

public class inputName : MonoBehaviour {
	public static string name;
	public UnityEngine.UI.InputField input;
	public UnityEngine.UI.Text nameDisplay;

	void Start()
	{
		name = "";
	}
	// Update is called once per frame
	void Update () {

		name = input.onValueChange.ToString();
		name = nameDisplay.text;
	}
}
