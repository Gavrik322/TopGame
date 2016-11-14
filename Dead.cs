using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

    public GameObject DeadMenu;
	void OnTriggerStay2D (Collider2D col) {
        if (col.gameObject.name == "Cube")
        {

            DeadMenu.SetActive(true);
            Time.timeScale = 0;

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
