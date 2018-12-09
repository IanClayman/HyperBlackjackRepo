using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpControlsScript : MonoBehaviour {

    public GameObject helpBackground;
    public GameObject closeHelpButton;

    public GameObject[] helpPages;

    public GameObject settingsMenu;

    int currPageIndex = 0;

	// Use this for initialization
	void Start () {
        helpBackground.SetActive(false);
        closeHelpButton.SetActive(false);

        foreach (GameObject page in helpPages)
        {
            page.SetActive(false);
        }

        settingsMenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void OpenHelpPages()
    {
        helpBackground.SetActive(true);
        closeHelpButton.SetActive(true);

        currPageIndex = 0;

        helpPages[currPageIndex].SetActive(true);
    }

    public void OpenSettingsPage()
    {
        helpBackground.SetActive(true);
        closeHelpButton.SetActive(true);

        settingsMenu.SetActive(true);
    }

    public void IncrementIndex()
    {
        currPageIndex++;

        foreach (GameObject page in helpPages)
        {
            page.SetActive(false);
        }

        helpPages[currPageIndex].SetActive(true);
    }

    public void DecrementIndex()
    {
        currPageIndex--;

        foreach (GameObject page in helpPages)
        {
            page.SetActive(false);
        }

        helpPages[currPageIndex].SetActive(true);
    }

    public void CloseHelpPages()
    {
        foreach (GameObject page in helpPages)
        {
            page.SetActive(false);
        }

        helpBackground.SetActive(false);
        closeHelpButton.SetActive(false);
        settingsMenu.SetActive(false);
    }
}
