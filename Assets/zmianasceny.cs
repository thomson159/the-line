using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zmianasceny : MonoBehaviour 
{

    public GameObject klik;

    public GameObject A;
    int wl = 0;
    public GameObject B;
    //public GameObject C;

    public GameObject tlocz;
    public GameObject tlonie;
    

    //public float postac = 0;

    // Use this for initialization
    void Start()
    {
        wl = 0;
        A.SetActive(true);
        B.SetActive(false);
        //C.SetActive(false);
        // postac = 0;
        tlonie.SetActive(false);
        tlocz.SetActive(true);
        //klik.SetActive(false);

    }
    //public float dupa = 0;
    //public bool tak2 = false;
    // Update is called once per frame
    void Update()
    {
        //PlayerPrefs.SetFloat("hero", postac);
        //if (tak2 == true)
        //{
        //    dupa++;
        //}
        //if (dupa == 10)
        //{
        //    klik.SetActive(false);
        //    tak2 = false;
        //    dupa = 0;
        //}
    }

    public void wylacz()
    {
        //if (postac < 2)
        //   // postac++;


        if (wl == 0)
        {
            A.SetActive(false);
            B.SetActive(true);
            wl = 1;

            tlonie.SetActive(true);
            tlocz.SetActive(false);
            //klik.SetActive(true);
            //tak2 = true;
        }
        //}
        //else if (wl == 1)
        //{
        //    B.SetActive(false);
        //    C.SetActive(true);
        //    wl = 2;
        //}
        //else if (wl == 2)
        //{
        //    A.SetActive(true);
        //    C.SetActive(false);
        //    //wl = 0;
        //    //postac = 3;
        //}
    }

    public void wlacz()
    {
        //if (postac > 0)
        //    postac--;

        if (wl == 0)
        {
            //A.SetActive(false);
            //B.SetActive(true);
            //wl = 1;
        }
        else if (wl == 1)
        {
            B.SetActive(false);
            A.SetActive(true);
            wl = 0;

            tlonie.SetActive(false);
            tlocz.SetActive(true);
           // klik.SetActive(true);
           // tak2 = true;
        }
        //else if (wl == 2)
        //{
        //    B.SetActive(true);
        //    C.SetActive(false);
        //    wl = 1;
        //    //postac = 3;
        //}
    }
}


