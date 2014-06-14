using UnityEngine;
using System.Collections;

public enum MainMenuButtonType
{
    START_GAME,
    EXIT_GAME,
};

public class ButtonMainMenu : MonoBehaviour {

    public MainMenuButtonType eButtonType = MainMenuButtonType.START_GAME;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseEnter()
    {
        Color newColor = Color.white;
        newColor.r = 1.0f;
        newColor.g = 1.0f;
        newColor.b = 0.5f;
        renderer.material.color = newColor;
    }
    void OnMouseExit()
    {
        Color newColor = Color.white;
        renderer.material.color = newColor;
    }

    void OnMouseDown()
    {
        if (eButtonType == MainMenuButtonType.START_GAME)
        {
            Application.LoadLevel("GameLevel");
        }
        else if (eButtonType == MainMenuButtonType.EXIT_GAME)
        {
            Application.Quit();
        }
    }

    internal MainMenuButtonType START_GAME { get; set; }
}
