using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SetScoreTextScript : MonoBehaviour {

    public string scoreString;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreString.ToLower() == "p1score")
        {
            this.GetComponent<TextMeshProUGUI>().SetText(Globals.p1score.ToString("00"));
        } else if (scoreString.ToLower() == "p2score")
        {
            this.GetComponent<TextMeshProUGUI>().SetText(Globals.p2score.ToString("00"));
        } else if (scoreString.ToLower() == "p3score")
        {
            this.GetComponent<TextMeshProUGUI>().SetText(Globals.p3score.ToString("00"));
        } else if (scoreString.ToLower() == "p4score")
        {
            this.GetComponent<TextMeshProUGUI>().SetText(Globals.p4score.ToString("00"));
        }
    }
}
