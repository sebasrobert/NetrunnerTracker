using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	void Start () {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 20;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {             
            SceneManager.LoadScene(0);
        }
    }
}
