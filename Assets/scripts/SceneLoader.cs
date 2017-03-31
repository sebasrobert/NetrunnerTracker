using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void openCorpScene () {
        SceneManager.LoadScene(1);
    }
	
    public void openRunnerScene () {
        SceneManager.LoadScene(2);
	}
}
