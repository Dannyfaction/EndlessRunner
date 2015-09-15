using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public GUISkin GameSkin;
	private bool _isFirstMenu = true;
	private string _gameName = "Hello Spooky";
	public Camera gameCamera;
	
	void OnGUI()
	{
		GUI.skin = GameSkin;
		GUI.Label(new Rect(30, 30, 300, 25), _gameName, "Menu Title");
		QualitySettings.SetQualityLevel(100, true);
		FirstMenu();
	}
	
	public void FirstMenu()
	{
		if (_isFirstMenu)
		{
			if (GUI.Button(new Rect(10, Screen.height / 2 - 30, 150, 25), "Start Game", "Button Style"))
			{
				Application.LoadLevel("Runner");
			}
			
			if (GUI.Button(new Rect(10, Screen.height / 2, 150, 25), "Quit Game", "Button Style"))
			{
				Application.Quit();
			}
		}
	}
}
