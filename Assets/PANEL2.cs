using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PANEL2 : MonoBehaviour
{

    public GameObject ob1;
    public GameObject but1;

    public GameObject box;

    public float kasa;
    float cena;
    public float koszt;
    public float cos;

    bool zatwierdz = true;

    public Text Money;

    void Start()
    {
        if (PlayerPrefs.GetFloat("zatwierdzpanel2") == 1)
        {
            but1.SetActive(false);
            box.SetActive(false);
        }
    }

    void Update()
    {

    }

    public void wlacz()
    {
        cos = PlayerPrefs.GetFloat("zatwierdzpanel2");
        if (cos != 1 && PlayerPrefs.GetFloat("Highscore2") >= 300)
        {
            ob1.SetActive(true);
            but1.SetActive(false);
        }
    }

    public void wylacz()
    {
        ob1.SetActive(false);
        if (zatwierdz == true)
        {
            but1.SetActive(true);
        }
    }

    public void kup()
    {
        kasa = PlayerPrefs.GetFloat("Highscore2");
        cena = kasa - koszt;
        PlayerPrefs.SetFloat("Highscore2", cena);
        zatwierdz = false;
        Money.text = "" + cena;
        PlayerPrefs.SetFloat("zatwierdzpanel2", 1);
        box.SetActive(false);
    }

}
