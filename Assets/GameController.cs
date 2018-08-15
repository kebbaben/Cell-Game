using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    
	
	void Update ()
    {
    #if UNITY_EDITOR 
        if (Input.GetButton("j1Exit") || Input.GetKeyDown(KeyCode.Escape))
                UnityEditor.EditorApplication.isPlaying = false;
    #endif
    #if UNITY_STANDALONE 
        if (Input.GetButton("j1Exit") || Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    #endif
        if (Input.GetKeyDown(KeyCode.F1))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
