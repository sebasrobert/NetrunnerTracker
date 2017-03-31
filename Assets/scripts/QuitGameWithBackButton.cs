using UnityEngine;
using System.Collections;

public class QuitGameWithBackButton : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { 
			Application.Quit(); 
		}
	}
}
