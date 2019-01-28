using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonContinue : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public void GoToGame()
    {
        GlobalSceneManager.current.ChangeScene("Stage One");
    }
}
