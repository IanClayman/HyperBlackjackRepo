using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SetTimerTextScript : MonoBehaviour {

    public string timerType;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int intTime = (int)Globals.timerTime;
        int seconds = intTime % 60;
        int milliseconds = (int)(Globals.timerTime * 100) % 100;

        if (timerType.ToLower() == "seconds")
        {
            this.GetComponent<TextMeshProUGUI>().SetText(seconds.ToString("00"));
        }

        if (timerType.ToLower() == "milliseconds")
        {
            this.GetComponent<TextMeshProUGUI>().SetText(milliseconds.ToString("00"));
        }
	}
}
