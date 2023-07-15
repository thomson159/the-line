using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menuctrl2 : MonoBehaviour
{

    public Text wynik;
    public Text wynik2;
    public Text wynik3;
    public Text wynik4;
    public Text wynik5;

    public void Start()
    {
        wynik.text = "" + PlayerPrefs.GetFloat("Highscore");
        wynik3.text = "" + PlayerPrefs.GetFloat("Highscore2");
        wynik4.text = "" + PlayerPrefs.GetFloat("Highscore2");
        wynik5.text = "" + PlayerPrefs.GetFloat("Highscore2");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Update()
    {
        wynik.text = "" + PlayerPrefs.GetFloat("Highscore");
        wynik2.text = "" + PlayerPrefs.GetFloat("Highscore");
        wynik4.text = "" + PlayerPrefs.GetFloat("Highscore2");
        wynik3.text = "" + PlayerPrefs.GetFloat("Highscore2");
    }
}
