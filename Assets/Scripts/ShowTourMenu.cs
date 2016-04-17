using UnityEngine;
using System.Collections;

public class ShowTourMenu : MonoBehaviour {

    public GameObject tourMenu;
    public bool isShowing;

    void Start()
    {
        tourMenu.SetActive(false);
    }

	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            tourMenu.SetActive(isShowing);
        }
	}
}
