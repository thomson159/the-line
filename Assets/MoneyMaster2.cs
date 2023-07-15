using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMaster2 : MonoBehaviour
{
    public float Money = 0.0f;

    private float Money2 = 0.0f;

    public Text MoneyText;
    public Text MoneyText2;
    public Text MoneyTextdiament;
    public Text MoneyTextdiament2;

    public Text MoneyTextdiament3;

    double HowOften = 40;

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    public GameObject e;
    public GameObject f;

    public GameObject g;

    public GameObject h;
    public GameObject i;

    public float tom = 0;
    public bool tak = true;

    private TheLineLudzik player;

    float postac;
    public GameObject j;
    public GameObject music;

    // WSZYSTKIE OBIEKTY MUSZA MIEC LAYER UL 

    void Start()
    {
        music.SetActive(false);

        postac = PlayerPrefs.GetFloat("hero");
        if (postac == 0)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<TheLineLudzik>();
        }
        if (postac == 1)
        {
            player = GameObject.FindGameObjectWithTag("Player2").GetComponent<TheLineLudzik>();
        }
        if (postac == 2)
        {
            player = GameObject.FindGameObjectWithTag("Player3").GetComponent<TheLineLudzik>();
        }
        if (postac == 3)
        {
            player = GameObject.FindGameObjectWithTag("Player4").GetComponent<TheLineLudzik>();
        }
        if (postac == 4)
        {
            player = GameObject.FindGameObjectWithTag("Player5").GetComponent<TheLineLudzik>();
        }
        if (postac == 5)
        {
            player = GameObject.FindGameObjectWithTag("Player6").GetComponent<TheLineLudzik>();
        }
        if (postac == 6)
        {
            player = GameObject.FindGameObjectWithTag("Player7").GetComponent<TheLineLudzik>();
        }
        if (postac == 7)
        {
            player = GameObject.FindGameObjectWithTag("Player8").GetComponent<TheLineLudzik>();
        }
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        e.SetActive(false);
        f.SetActive(false);
        g.SetActive(false);
        h.SetActive(true);
        i.SetActive(true);

        MoneyTextdiament3.text = "" + PlayerPrefs.GetFloat("Highscore2");
    }

    float cos = 0.0f;
    float cos2;

    public void Update()
    {
        
        //MoneyText.text = "" + Money; // wyswietla wynik 

        //if (Time.time > HowOften)
        //{
        //    //Money++;
        //    HowOften = HowOften + 0.5;

        //    if (player.MaxHealth > 0)
        //    {
        //        Money++;
        //        MoneyText.text = "" + Money; // wyswietla wynik
        //    }
        //}

        if (player.MaxHealth == 0)
        {
            h.SetActive(false);
            i.SetActive(false);
            j.SetActive(false);
        }

        MoneyTextdiament.text = "" + Money2;
        MoneyTextdiament2.text = "" + costam;

        tom++;

        if (player.MaxHealth == 0 && tak == true)
        {
            tak = false;
            Diamenty();
        }

        if (tom > HowOften)
        {
            //Money++;
            HowOften = HowOften + 40;

            //if (player.MaxHealth == 0)
            //{
            //    cos++;
            //    MoneyTextdiament2.text = "" + cos;
            //}

            if (player.MaxHealth > 0)
            {
                Money++;
                MoneyText.text = "" + Money; // wyswietla wynik
                MoneyText2.text = "" + Money;
            }

            if (PlayerPrefs.GetFloat("Highscore4") < Money)
            {
                PlayerPrefs.SetFloat("Highscore4", Money);

                a.SetActive(false);
                b.SetActive(false);
                c.SetActive(false);
                d.SetActive(false);

                e.SetActive(true);
                f.SetActive(true);

                if (Money > 10)
                {
                    g.SetActive(true);
                }
            }
        }
        if (tak2 == true)
        {
            dupa++;
        }
        if (dupa == 50)
        {
            music.SetActive(false);
            tak2 = false;
            dupa = 0;
        }

    }
    public float dupa = 0;
    public bool tak2 = false;

    public void AddMoney(int Score)
    {
        music.SetActive(true);
        Money2 += Score;

        tak2 = true;
    }

    public float costam = 0.0f;
    public float costam2 = 0.0f;

    public void Diamenty()
    {
        costam = PlayerPrefs.GetFloat("Highscore2") + Money2;
        //costam2 = PlayerPrefs.GetFloat("Highscore3");
        PlayerPrefs.SetFloat("Highscore2", costam);
        PlayerPrefs.SetFloat("Highscore3", costam);
        //PlayerPrefs.SetFloat("Highscore3", costam2);
    }

    //public void AddMoney(int Money)
    //{
    //    if (player.MaxHealth == 0)
    //    {
    //        PlayerPrefs.SetInt("Highscore", Money);
    //    }
    //}
}
