using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TimerColorScript : MonoBehaviour {
    public Color TargetColor;

    float timerStartTime;
    public Color startColor;

	// Use this for initialization
	void Start () {
        timerStartTime = GameObject.Find("Controller").GetComponent<Globals>().setTimerTime;
        Debug.Log(timerStartTime);
        startColor = this.GetComponent<Image>().color;
	}
	
	// Update is called once per frame
	void Update () {
        float t = (timerStartTime - Globals.timerTime) / timerStartTime;
        this.GetComponent<Image>().color = Color.Lerp(startColor, TargetColor, t);
	}
}
