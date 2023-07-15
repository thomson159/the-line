using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herochange : MonoBehaviour
{
    float postac;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;

    //public GameObject Bu1;
    //public GameObject Bu2;

    void Start()
    {
        postac = PlayerPrefs.GetFloat("hero");

        if (postac == 0)
        {
            A.SetActive(true);
            B.SetActive(false);
            C.SetActive(false);
            D.SetActive(false);
            E.SetActive(false);
            F.SetActive(false);
            G.SetActive(false);
            H.SetActive(false);
            //Bu1.SetActive(false);
            //Bu2.SetActive(true);
            //Destroy(B.gameObject);
            //Destroy(C.gameObject);
            //Destroy(D.gameObject);
        }
        else if (postac == 1)
        {
            A.SetActive(false);
            B.SetActive(true);
            C.SetActive(false);
            D.SetActive(false);
            E.SetActive(false);
            F.SetActive(false);
            G.SetActive(false);
            H.SetActive(false);
            //Bu1.SetActive(false);
            //Bu2.SetActive(true);
            //Destroy(A.gameObject);
            //Destroy(C.gameObject);
            //Destroy(D.gameObject);
        }
        else if (postac == 2)
        {
            A.SetActive(false);
            B.SetActive(false);
            C.SetActive(true);
            D.SetActive(false);
            E.SetActive(false);
            F.SetActive(false);
            G.SetActive(false);
            H.SetActive(false);
            //Bu1.SetActive(false);
            //Bu2.SetActive(true);
            //Destroy(A.gameObject);
            //Destroy(B.gameObject);
            //Destroy(D.gameObject);
        }
        else if (postac == 3)
        {
            A.SetActive(false);
            B.SetActive(false);
            C.SetActive(false);
            D.SetActive(true);
            E.SetActive(false);
            F.SetActive(false);
            G.SetActive(false);
            H.SetActive(false);
            //Bu1.SetActive(false);
            //Bu2.SetActive(true);
            //Destroy(A.gameObject);
            //Destroy(B.gameObject);
            //Destroy(C.gameObject);
        }
        else if (postac == 4)
        {
            A.SetActive(false);
            B.SetActive(false);
            D.SetActive(false);
            C.SetActive(false);
            E.SetActive(true);
            F.SetActive(false);
            G.SetActive(false);
            H.SetActive(false);
            //Bu1.SetActive(false);
            //Bu2.SetActive(true);
            //Destroy(A.gameObject);
            //Destroy(B.gameObject);
            //Destroy(C.gameObject);
        }
        else if (postac == 5)
        {
            A.SetActive(false);
            B.SetActive(false);
            D.SetActive(false);
            C.SetActive(false);
            E.SetActive(false);
            F.SetActive(true);
            G.SetActive(false);
            H.SetActive(false);
            //Bu1.SetActive(false);
            //Bu2.SetActive(true);
            //Destroy(A.gameObject);
            //Destroy(B.gameObject);
            //Destroy(C.gameObject);
        }
        else if (postac == 6)
        {
            A.SetActive(false);
            B.SetActive(false);
            D.SetActive(false);
            C.SetActive(false);
            E.SetActive(false);
            F.SetActive(false);
            G.SetActive(true);
            H.SetActive(false);
            //Bu1.SetActive(true);
            //Bu2.SetActive(false);
            //Destroy(A.gameObject);
            //Destroy(B.gameObject);
            //Destroy(C.gameObject);
        }
        else if (postac == 7)
        {
            A.SetActive(false);
            B.SetActive(false);
            D.SetActive(false);
            C.SetActive(false);
            E.SetActive(false);
            F.SetActive(false);
            G.SetActive(false);
            H.SetActive(true);
            //Bu1.SetActive(true);
            //Bu2.SetActive(false);
            //Destroy(A.gameObject);
            //Destroy(B.gameObject);
            //Destroy(C.gameObject);
        }
    }

    void Update()
    {
        //if (postac == 0)
        //{
        //    A.SetActive(true);
        //    B.SetActive(false);
        //    C.SetActive(false);
        //}
        //else if (postac == 1)
        //{
        //    A.SetActive(false);
        //    B.SetActive(true);
        //    C.SetActive(false);
        //}
        //else if (postac == 2)
        //{
        //    A.SetActive(false);
        //    B.SetActive(false);
        //    C.SetActive(true);
        //}
    }
}
