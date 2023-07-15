using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzialo2 : MonoBehaviour
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
    void Start()
    {
        

        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time > NextBullet)
        {
            ra = Random.Range(0f, 1.25f);
            //los = Random.Range(0.0f, 0.9f);
            NextBullet = Time.time + HowOften;// + los;

            pomin = 0;

            if (ra < 0.25 && tak == 0 && kolejka == 2)
            {
                while (ra < 0.25)
                {
                    ra = Random.Range(0f, 1.25f);
                }
                if (ra >= 0.25)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }

            else if (ra >= 1.0 && ra < 1.25 && kolejka == 6)
            {
                Instantiate(Bullet7, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 0;
                pomin = 1;
            }

            else if (ra >= 0.25 && ra < 0.5 && kolejka == 3)
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
            else if (ra >= 0.5 && ra < 0.75 && kolejka == 4)
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
            else if (ra >= 0.75 && ra < 1 && kolejka == 5)
            {
                while (ra >= 0.75 && ra < 1)
                {
                    ra = Random.Range(0f, 1.25f);
                }
                if (ra < 0.75 || ra >= 1)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }



            //else if(kolejka == 7)
            //{
            //    Instantiate(Bullet6, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            //    kolejka = 0;
            //}

            //else if(kolejka == 8)
            //{
            //    Instantiate(Bullet8, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            //    kolejka = 0;
            //}
            
            if (ra < 0.25 && tak == 0)
            {
                Instantiate(Bullet2, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                Instantiate(dia, Gun2.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 2;
            }

            else if (tak > 0)
            {
                tak--;
            }

            else if (ra >= 0.25 && ra < 0.5 && tak == 0)
            {
                Instantiate(Bullet3, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                tak = 1;
                kolejka = 3;
            }

            else if (ra >= 0.5 && ra < 0.75 && tak == 0)
            {
                Instantiate(Bullet4, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 4;
            }

            else if (ra >= 0.75 && ra < 1 && tak == 0)
            {
                Instantiate(Bullet5, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                tak = 2;
                kolejka = 5;
            }

            else if (ra >= 1.0 && ra < 1.25 && tak == 0 && pomin == 0)
            {
                Instantiate(Bullet6, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 6;
                
            }

        }
    }
}
