using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuctrl : MonoBehaviour {

    public Text wynik;
    public Text wynik2;
    public Text wynik7;
    public Text wynik3;
    public Text wynik4;
    public Text wynik5;
    public Text wynik6;

    public void Start()
    {
        Screen.autorotateToPortrait = false;

        Screen.autorotateToPortraitUpsideDown = false;

        Screen.orientation = ScreenOrientation.AutoRotation;


        wynik.text = "" + PlayerPrefs.GetFloat("Highscore");
        wynik3.text = "" + PlayerPrefs.GetFloat("Highscore2");
        wynik4.text = "" + PlayerPrefs.GetFloat("Highscore2");
        wynik5.text = "" + PlayerPrefs.GetFloat("Highscore2");

        wynik6.text = "" + PlayerPrefs.GetFloat("Highscore4");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Update()
    {
        wynik6.text = "" + PlayerPrefs.GetFloat("Highscore4");
        wynik7.text = "" + PlayerPrefs.GetFloat("Highscore4");
        wynik.text = "" + PlayerPrefs.GetFloat("Highscore");
        wynik2.text = "" + PlayerPrefs.GetFloat("Highscore");
        wynik4.text = "" + PlayerPrefs.GetFloat("Highscore2");
        wynik3.text = "" + PlayerPrefs.GetFloat("Highscore2");

    }
}
