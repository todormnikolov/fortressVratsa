using UnityEngine;
using System.Collections;

public class TourMenu : MonoBehaviour {

    public GameObject tourMenu;

    public void PauseTour()
    {
        tourMenu.SetActive(false);
    }

    public void EndTour()
    {
        Application.LoadLevel(0);
    }

    public void ExitProgram()
    {
        Application.Quit();
    }
}
