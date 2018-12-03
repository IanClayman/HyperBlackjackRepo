using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour {
    [Range(1, 10)]
    public int setTimerTime = 5;

    public static int p1score = 0;
    public static int p2score = 0;
    public static int p3score = 0;
    public static int p4score = 0;

    public static float timerTime;

    public bool roundStarted = false;

	// Use this for initialization
	void Start () {
        timerTime = setTimerTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (roundStarted)
        {
            timerTime -= Time.deltaTime;
            timerTime = Mathf.Clamp(timerTime, 0, setTimerTime);
        }

        p1score = Mathf.Clamp(p1score, 0, 99);
        p2score = Mathf.Clamp(p2score, 0, 99);
        p3score = Mathf.Clamp(p3score, 0, 99);
        p4score = Mathf.Clamp(p4score, 0, 99);

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("p1score: " + p1score + "\n");
            Debug.Log("p2score: " + p2score + "\n");
            Debug.Log("p3score: " + p3score + "\n");
            Debug.Log("p4score: " + p4score + "\n");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            timerTime = setTimerTime;
        }
    }

    public void ResetTimer()
    {
        timerTime = setTimerTime;
        if (!roundStarted)
            roundStarted = true;
    }
}
