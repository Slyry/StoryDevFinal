using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;

	public bool hide1Pressed = false;
	public bool hide2Pressed = false;
	public bool hide3Pressed = false;
	public bool hide4Pressed = false;
	public bool escapePressed = false;

	private void Awake()
	{
		if (instance == null) 
		{
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} 
		else 
		{
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () 
	{
		GameObject.Find ("Escape Button").SetActive (false);
	}
}
