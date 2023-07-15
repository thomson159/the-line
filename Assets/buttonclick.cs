using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonclick : MonoBehaviour
{

    public GameObject A;
    int wl = 0;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;

    public float postac = 0;

    // Use this for initialization
    void Start ()
    {
        wl = 0;
        A.SetActive(true);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
        F.SetActive(false);
        G.SetActive(false);
        H.SetActive(false);
        postac = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerPrefs.SetFloat("hero", postac);
    }

    public void yourhero()
    {
        PlayerPrefs.SetFloat("hero", postac);
    }

    public void wylacz()
    {
        if(postac < 7)
        postac++;

        if (wl == 0)
        {
            A.SetActive(false);
            B.SetActive(true);
            wl = 1;
        }
        else if (wl == 1)
        {
            B.SetActive(false);
            C.SetActive(true);
            wl = 2;
        }
        else if (wl == 2)
        {
            D.SetActive(true);
            C.SetActive(false);
            wl = 3;
        }
        else if(wl == 3)
        {
            D.SetActive(false);
            E.SetActive(true);
            wl = 4;
        }
        else if (wl == 4)
        {
            E.SetActive(false);
            F.SetActive(true);
            wl = 5;
        }
        else if (wl == 5)
        {
            F.SetActive(false);
            G.SetActive(true);
            wl = 6;
        }
        else if (wl == 6)
        {
            G.SetActive(false);
            H.SetActive(true);
            wl = 7;
        }
    }

    public void wlacz()
    {
        if(postac > 0)
        postac--;

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
        }
        else if (wl == 2)
        {
            B.SetActive(true);
            C.SetActive(false);
            wl = 1;
            //postac = 3;
        }
        else if(wl == 3)
        {
            D.SetActive(false);
            C.SetActive(true);
            wl = 2;
        }
        else if(wl == 4)
        {
            E.SetActive(false);
            D.SetActive(true);
            wl = 3;
        }
        else if (wl == 5)
        {
            F.SetActive(false);
            E.SetActive(true);
            wl = 4;
        }
        else if (wl == 6)
        {
            F.SetActive(true);
            G.SetActive(false);
            wl = 5;
        }
        else if (wl == 7)
        {
            H.SetActive(false);
            G.SetActive(true);
            wl = 6;
        }
    }
}
