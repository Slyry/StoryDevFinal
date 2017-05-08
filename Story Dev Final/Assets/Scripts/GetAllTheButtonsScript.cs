using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GetAllTheButtonsScript : MonoBehaviour 
{
	[SerializeField] GameObject hideButton1;
	[SerializeField] GameObject hideButton2;
	[SerializeField] GameObject hideButton3;
	[SerializeField] GameObject hideButton4;
	[SerializeField] GameObject escapeButton;
	[SerializeField] GameObject youAreHere;

	private GameObject gameManager;
	private GameManager gameManagerScript;

	void Start()
	{
		gameManager = GameObject.Find ("Game Manager");
		gameManagerScript = gameManager.GetComponent<GameManager> ();

		WhichButtonWasPressed ();
	}

	void Update()
	{
		
	}

	void WhichButtonWasPressed()
	{
		if (gameManagerScript.hide1Pressed == true) 
		{
			youAreHere.transform.position = hideButton1.transform.position;
			hideButton1.SetActive (false);
			hideButton2.SetActive (false);
			hideButton3.SetActive (false);
			hideButton4.SetActive (false);
			escapeButton.SetActive (true);
		} 
		else if (gameManagerScript.hide2Pressed == true) 
		{
			youAreHere.transform.position = hideButton2.transform.position;
			hideButton1.SetActive (false);
			hideButton2.SetActive (false);
			hideButton3.SetActive (false);
			hideButton4.SetActive (false);
			escapeButton.SetActive (true);
		} 
		else if (gameManagerScript.hide3Pressed == true) 
		{
			youAreHere.transform.position = hideButton3.transform.position;
			hideButton1.SetActive (false);
			hideButton2.SetActive (false);
			hideButton3.SetActive (false);
			hideButton4.SetActive (false);
			escapeButton.SetActive (true);
		} 
		else if (gameManagerScript.hide4Pressed == true) 
		{
			youAreHere.transform.position = hideButton4.transform.position;
			hideButton1.SetActive (false);
			hideButton2.SetActive (false);
			hideButton3.SetActive (false);
			hideButton4.SetActive (false);
			escapeButton.SetActive (true);
		}
	}

	public void HideButton1Pressed()
	{
		gameManagerScript.hide1Pressed = true;
		SceneManager.LoadScene ("Game");
	}

	public void HideButton2Pressed()
	{
		gameManagerScript.hide2Pressed = true;
		SceneManager.LoadScene ("Game");
	}

	public void HideButton3Pressed()
	{
		gameManagerScript.hide3Pressed = true;
		SceneManager.LoadScene ("Game");
	}

	public void HideButton4Pressed()
	{
		gameManagerScript.hide4Pressed = true;
		SceneManager.LoadScene ("Game");
	}

	public void EscapeButtonPressed()
	{

	}
}
