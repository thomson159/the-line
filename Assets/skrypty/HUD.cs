using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprites;

    public Image HeartUI;

    private TheLineLudzik player;

    public GameObject PauseUL;
    public GameObject but1;
    public GameObject but2;
    public GameObject b;
    private bool paused = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<TheLineLudzik>();
        //wynik = GameObject.FindGameObjectWithTag("wynik").GetComponent<MoneyMaster>();
        PauseUL.SetActive(false);
    }

    void Update()
    {
        //HeartUI.sprite = HeartSprites[player.MaxHealth];

        if(Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        //if (paused)
        //{
        //    PauseUL.SetActive(true);
        //    Time.timeScale = 0;
        //}
        //else
        //{
        //    PauseUL.SetActive(false);
        //    Time.timeScale = 1;
        //}

        if (player.MaxHealth == 0)
        {
            PauseUL.SetActive(true);
            but1.SetActive(false);
            but2.SetActive(false);
            b.SetActive(false);
            //Time.timeScale = 0;
        }
        
    }
}
