using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	// Use this for initialization
	void OnTriggerStay2D (Collider2D col) {
        if (col.gameObject.name == "Cube") 
        Application.LoadLevel("Level1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
