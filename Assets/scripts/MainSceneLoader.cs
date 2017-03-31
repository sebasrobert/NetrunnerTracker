using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 20;
	}	
}
