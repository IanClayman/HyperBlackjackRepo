using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour {
    [Range(1, 10)]
    public int setTimerTime = 5;
    public AudioSource buzzer;

    public static int p1score = 0;
    public static int p2score = 0;
    public static int p3score = 0;
    public static int p4score = 0;

    public static float timerTime;

    public bool roundStarted = false;
    public bool buzzerPlayed = false;

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;

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

        if (timerTime <= 0 && !buzzerPlayed)
        {
            buzzer.time = 1.25f;
            buzzer.Play();
            buzzerPlayed = true;
        }

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
        buzzerPlayed = false;
        if (!roundStarted)
            roundStarted = true;
    }

    public void ResetAndPause()
    {
        timerTime = setTimerTime;
        roundStarted = false;
        buzzerPlayed = false;
    }

    public void ResetScores()
    {
        p1score = 0;
        p2score = 0;
        p3score = 0;
        p4score = 0;
    }

    public void ChangeTimerTime(int t)
    {
        setTimerTime = t;
    }
}
