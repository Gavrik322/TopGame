using UnityEngine;
using System.Collections;


public class LevelMenu : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown () {
	
	}
	
	// Update is called once per frame
	void OnMouseUp() {
	
	}
    void OnMouseUpAsButton() {

        Application.LoadLevel("Menu");


    }
}
