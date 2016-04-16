using UnityEngine;
//using UnityEngine.UI;
using System.Collections;
using System;

public class MainMenu : MonoBehaviour {

    public void RunTour()
    {
        Application.LoadLevel("PlaneScene");
    }

    public void ExitProgram (){ 
        Application.Quit();
	}
}
