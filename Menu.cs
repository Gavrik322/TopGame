using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown() {
       
	}
	
	// Update is called once per frame
	void OnMouseUp() {
	
	}
    void OnMouseUpAsButton() {

        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("Game");
                break;
            case "Level":
                Application.LoadLevel("Level");
                break;
        }

        }
}

