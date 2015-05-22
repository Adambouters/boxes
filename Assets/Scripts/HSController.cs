using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Author: Troy Reynolds
//Created 5/21/2015
public class HSController : MonoBehaviour
{
	private string secretKey = "!@#$%^&*()"; // Edit this value and make sure it's the same as the one stored on the server
	public string addScoreURL = "http://104.131.61.212/boxesaddscore.php?"; //be sure to add a ? to your url
	public string highscoreURL = "http://104.131.61.212/boxesdisplay.php";
	private int score;
	Text allHighScores;

	
	void Start()
	{
		allHighScores = GetComponent<Text>();
		highscoreURL = "http://104.131.61.212/boxesdisplay.php";
		StartCoroutine(GetScores());
		addScoreURL = "http://104.131.61.212/boxesaddscore.php?"; //be sure to add a ? to your url
	}
	public void submit()
	{
		//Debug.LogWarning ("Score is " + keepScore.getOverallScore ());
		//int.TryParse( Mathf.CeilToInt(keepScore.getOverallScore()).ToString(),out score);
		Debug.LogWarning ("After the int score is" + score);
		StartCoroutine (PostScores (inputName.name.ToString(), score));
	}
	// remember to use StartCoroutine when calling this function!
	IEnumerator PostScores(string name, int score)
	{
		Debug.LogWarning ("In post");
		//This connects to a server side php script that will add the name and score to a MySQL DB.
		// Supply it with a string representing the players name and the players score.
		string hash = MD5Test.Md5Sum(name + score + secretKey);
		Debug.LogWarning (addScoreURL);
		string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score + "&hash=" + hash;
		
		// Post the URL to the site and create a download object to get the result.
		WWW hs_post = new WWW(post_url);
		yield return hs_post; // Wait until the download is done
		
		if (hs_post.error != null)
		{
			Debug.LogWarning("There was an error posting the high score: " + hs_post.error);
		}

	}
	
	// Get the scores from the MySQL DB to display in a GUIText.
	// remember to use StartCoroutine when calling this function!
	IEnumerator GetScores()
	{

		allHighScores.text = "Loading Scores";
		WWW hs_get = new WWW(highscoreURL);
		yield return hs_get;
		
		if (hs_get.error != null)
		{
			Debug.LogWarning("There was an error getting the high score: " + hs_get.error);
		}
		else
		{
			allHighScores.text = hs_get.text; // this is a GUIText that will display the scores in game.
		}
	}
	
}