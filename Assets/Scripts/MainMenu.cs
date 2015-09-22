using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	[SerializeField]
	private GUISkin GameSkin;
	private bool _isFirstMenu = true;
	private string _gameName = "Hello Spooky";
	[SerializeField]
	private Camera gameCamera;
	private string stringToEdit;
	
	void OnGUI()
	{
		GUI.skin = GameSkin;
		GUI.Label(new Rect(30, 30, 300, 25), _gameName, "Menu Title");
		stringToEdit = "How To Play \n Fade through walls and collect Ectoplasm. \n Change color by using the 1,2 and 3 keys on \n your keyboard. You need to be the color of the \n object you want to fly through/collect in order to.";
		QualitySettings.SetQualityLevel(100, true);
		FirstMenu();
	}
	
	public void FirstMenu()
	{
		if (_isFirstMenu)
		{
			//GUI.Box(new Rect((Screen.width / 2)-440,(Screen.height / 2) + 45, 150, 150), "How To Play", "Box Style");
			GUI.TextArea(new Rect((Screen.width / 2)-440,(Screen.height / 2) + 45, 320, 150), stringToEdit, "Box Style");
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
