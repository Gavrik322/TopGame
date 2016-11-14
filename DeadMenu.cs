using UnityEngine;
using System.Collections;

public class DeadMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseUpAsButton()
    {

        switch (gameObject.name)
        {
            case "Menu":
                Application.LoadLevel("Menu");
                Time.timeScale = 1;
                break;
            case "Level":
                Application.LoadLevel("LevelMenu");
                Time.timeScale = 1;
                break;
            case "Restart":
                Application.LoadLevel(Application.loadedLevel);
                Time.timeScale = 1;
                break;
                
        }


    }
}
