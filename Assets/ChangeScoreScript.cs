using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeScoreScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementP1Score()
    {
        Globals.p1score++;
    }

    public void DecrementP1Score()
    {
        if(Globals.p1score != 0)
            Globals.p1score--;
    }

    public void IncrementP2Score()
    {
        Globals.p2score++;
    }

    public void DecrementP2Score()
    {
        if (Globals.p2score != 0)
            Globals.p2score--;
    }

    public void IncrementP3Score()
    {
        Globals.p3score++;
    }

    public void DecrementP3Score()
    {
        if (Globals.p3score != 0)
            Globals.p3score--;
    }

    public void IncrementP4Score()
    {
        Globals.p4score++;
    }

    public void DecrementP4Score()
    {
        if (Globals.p4score != 0)
            Globals.p4score--;
    }
}
