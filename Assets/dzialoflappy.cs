using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzialoflappy : MonoBehaviour
{
    public Transform Gun;
    public Transform Gun2;
    public Transform Gun3;
    public Transform Gun4;
    public Transform Gun5;
    public Transform Gun6;
    public Transform Gun7;

    public GameObject Bullet7;
    public GameObject Bullet8;
    public GameObject Bullet9;
    public GameObject Bullet1;

    public float NextBullet;
    public float HowOften;

    public float NextBullet2;
    public float HowOften2;

    float ra;
    int kolejka = 0;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (Time.time > NextBullet2 && ra < 1)
        {
            NextBullet2 = Time.time + HowOften2;

            Instantiate(Bullet7, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            Instantiate(Bullet8, Gun2.position, Quaternion.Euler(new Vector2(0, 0)));
        }

        if (Time.time > NextBullet)
        {
            ra = Random.Range(0f, 1.5f);

            NextBullet = Time.time + HowOften;
            
            if (ra <= 0.5 && kolejka == 1)
            {
                while (ra <= 0.5)
                {
                    ra = Random.Range(0f, 1.5f);
                }
                if (ra > 0.5)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }
            else if (ra > 0.5 && ra < 1 && kolejka == 2)
            {
                while (ra > 0.5 && ra < 1)
                {
                    ra = Random.Range(0f, 1.5f);
                }
                if (ra <= 0.5 || ra >= 1)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }
            else if (ra >= 1 && kolejka == 3)
            {
                while (ra >= 1)
                {
                    ra = Random.Range(0f, 1.5f);
                }
                if (ra < 1)
                {
                    kolejka = 0;
                    //kolejka2 = 0;
                }
            }
            
            if (ra <= 0.5)
            {
                Instantiate(Bullet9, Gun3.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 1;
            }
            else if (ra > 0.5 && ra < 1)
            {
                Instantiate(Bullet9, Gun4.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 2;
            }
            else if (ra >= 1)
            {
                Instantiate(Bullet9, Gun5.position, Quaternion.Euler(new Vector2(0, 0)));
                kolejka = 3;
                Instantiate(Bullet1, Gun6.position, Quaternion.Euler(new Vector2(0, 0)));
                Instantiate(Bullet1, Gun7.position, Quaternion.Euler(new Vector2(0, 0)));
            }
        }
    }
}
