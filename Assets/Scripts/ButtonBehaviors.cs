using UnityEngine;
using System.Collections;

//Author: Troy Reynolds
//Created 5/21/2015

//This will have the functionality of all the buttons for the menus:
public class ButtonBehaviors : MonoBehaviour {
	public GameObject[] mainMenuButtons = new GameObject[3];
	public GameObject mainMenu;
	public GameObject score;
	public GameObject input;
	public GameObject submitScore;
	public GameObject SubmitToGlobal;
	public GameObject globalMainMenu;


	public void GlobalMainMenu()
	{
		globalMainMenu.SetActive (false);
		MainMenuButtonOn ();
	}
	public void PlayButton()
	{
		//Application.LoadLevel("GamePlay");
		MainMenuButtonOff ();
		mainMenu.SetActive (true);

		submitScore.SetActive (true);
	}
	public void PersonalHighScore()
	{
		submitScore.SetActive (false);
		MainMenuButtonOff ();
		mainMenu.SetActive(true);
		score.SetActive (true);


		//This will show the high score that Adam has made

	}

	public void GlobalHighScores()
	{
		MainMenuButtonOff ();
		globalMainMenu.SetActive (true);
		//This will show all the high scores from the database
	}
	public void MainMenu()
	{
		MainMenuButtonOn ();
		mainMenu.SetActive(false);
		score.SetActive (false);
		submitScore.SetActive (false);

	}
	public void SubmitScore()
	{
		input.SetActive (true);
		mainMenu.SetActive(false);
		submitScore.SetActive (false);
		SubmitToGlobal.SetActive (true);

	}
	public void SubmitToGLobal()
	{
		input.SetActive (false);
		SubmitToGlobal.SetActive (false);
		MainMenuButtonOn ();
	}
	private void MainMenuButtonOff()
	{
		mainMenuButtons [0].SetActive (false);
		mainMenuButtons [1].SetActive (false);
		mainMenuButtons [2].SetActive (false);

	}
	private void MainMenuButtonOn()
	{
		mainMenuButtons [0].SetActive (true);
		mainMenuButtons [1].SetActive (true);
		mainMenuButtons [2].SetActive (true);
	}


}
