using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzialo : MonoBehaviour
{

    public Transform Gun;
    public Transform Gun2;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public GameObject Bullet4;
    public GameObject Bullet5;

    public GameObject Bullet6;

    public GameObject Bullet7;
    public GameObject Bullet8;

    public GameObject dia;

    public float HowOften; // co ile moze strzelac
    public float NextBullet;

    Rigidbody2D RB;
    Animator anim;

    float los;
    float ra;
    float ra2;

    int tak = 0;

    int kolejka = 0;
    int kolejka2 = 0;
    int pomin = 0;

    // Use this for initialization
    void Start ()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Time.time > NextBullet)
        {
            ra = Random.Range(0f, 1.25f);
            //los = Random.Range(0.0f, 0.9f);
            NextBullet = Time.time + HowOften;// + los;
            
            if (ra < 0.25 && /*kolejka2 == 2*/ kolejka == 2)
            {
                while (ra < 0.25)
                {
                    ra = Random.Range(0f, 1.25f);
                }
                if (ra >= 0.25)
                {
                    //kolejka2 = 0;
                    kolejka = 0;
                }
            }

            if (ra >= 0.25 && ra < 0.5 && kolejka == 1)
            {
                while (ra >= 0.25 && ra < 0.5)
                {
                    ra = Random.Range(0f, 1.25f);
                }
                if (ra < 0.25 || ra >= 0.5)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }

            if (ra >= 0.5 && ra < 0.75 && kolejka == 3)
            {
                while (ra >= 0.5 && ra < 0.75)
                {
                    ra = Random.Range(0f, 1.25f);
                }
                if (ra < 0.5 || ra >= 0.75)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }

            if (ra >= 0.75 && ra < 1.0 && kolejka == 4)
            {
                while (ra >= 0.75 && ra < 1.0)
                {
                    ra = Random.Range(0f, 1.25f);
                }
                if (ra < 0.75 || ra >= 1)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }

            if (ra >= 1.0 && ra < 1.25 && kolejka == 5)
            {
                Instantiate(Bullet7, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 0;
                //kolejka2 = 0;
                tak = 1;

                //ra2 = Random.Range(0f, 1.5f);

                //if (ra2 >= 0 && ra2 < 0.5)
                //{
                //    Instantiate(Bullet6, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                //    kolejka = 0;
                //    kolejka2 = 0;
                //}
                //if (ra2 >= 0.5 && ra2 < 1.0)
                //{
                //    Instantiate(Bullet7, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                //    kolejka = 0;
                //    kolejka2 = 0;
                //}
                //if (ra2 >= 1.0)
                //{
                //    while (ra >= 1.0 && ra < 1.25)
                //    {
                //        ra = Random.Range(0f, 1.25f);
                //    }
                //    if (ra < 1.0 || ra >= 1.25)
                //    {
                //        kolejka = 0;
                //        kolejka2 = 0;
                //    }
                //}
            }

            if (ra < 0.25 && tak == 0)
            {
                Instantiate(Bullet2, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                Instantiate(dia, Gun2.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka2++;
                //if (pomin == 1)
                //{
                //    HowOften = HowOften + 0.05f;
                //    pomin = 0;
                //}
            }

            else if (tak == 1)
            {
                tak = 0;
            }

            else if (tak == 2)
            {
                tak = 1;
            }

            else if (ra >= 0.25 && ra < 0.5 && tak == 0)
            {
                Instantiate(Bullet3, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                tak = 1;
                kolejka++;
                //if (pomin == 1)
                //{
                //    HowOften = HowOften + 0.05f;
                //    pomin = 0;
                //}
            }

            else if (ra >= 0.5 && ra < 0.75 && tak == 0)
            {
                Instantiate(Bullet4, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                tak = 0;
                kolejka = 3;
                //if(pomin == 1)
                //{
                //    HowOften = HowOften + 0.05f;
                //    pomin = 0;
                //}
            }

            else if (ra >= 0.75 && ra < 1 && tak == 0)
            {
                Instantiate(Bullet5, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                tak = 2;
                kolejka = 4;
                //if (pomin == 0)
                //{
                //    HowOften = HowOften - 0.05f;
                //    pomin = 1;
                //}
            }

            else if (ra >= 1.0 && ra < 1.25 && tak == 0)
            {
                Instantiate(Bullet6, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                tak = 0;
                kolejka = 5;
                //if (pomin == 1)
                //{
                //    HowOften = HowOften + 0.05f;
                //    pomin = 0;
                //}
            }
                
        }
    } //////////// pozmieniac ra wszedzie !!!!!!!!!!!!!!!!!!!!!!!!!!!
    
}
