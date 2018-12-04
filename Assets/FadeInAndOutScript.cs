using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Image))]
public class FadeInAndOutScript : MonoBehaviour {
    [Range(0.5f, 10f)]
    public float fadeTime = 3;

    [Range(0.5f, 3)]
    public float pauseTime = 2;

    float t1 = 0;
    float t2 = 1;
    float tPause = 0;
    Color startColor;
    Color transparentColor;
	// Use this for initialization
	void Start () {
        startColor = this.GetComponent<Image>().color;
        transparentColor = new Color(startColor.r, startColor.g, startColor.b, 0);

        this.GetComponent<Image>().color = transparentColor;

        StartCoroutine(LoadNextScene());
    }
	
	// Update is called once per frame
	void Update () {
        if (t1 <= 1)
        {
            this.GetComponent<Image>().color = Color.Lerp(transparentColor, startColor, t1);
            t1 += Time.deltaTime / fadeTime;
        } else
        {
            tPause += Time.deltaTime / pauseTime;
        }

        if (tPause > 1 && tPause > 1)
        {
            this.GetComponent<Image>().color = Color.Lerp(transparentColor, startColor, t2);
            t2 -= Time.deltaTime / fadeTime;
        }

        Debug.Log("t1: " + t1 + " | t2: " + t2);
	}

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds((2 * fadeTime) + pauseTime + 0.125f);
        SceneManager.LoadScene(1);
    }
}
