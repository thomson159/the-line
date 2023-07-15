using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzialopizza : MonoBehaviour {

    public Transform Gun;
    public GameObject Bullet;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public float HowOften; // co ile moze strzelac
    public float NextBullet;

    Rigidbody2D RB;
    Animator anim;
    
    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public float a =0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > NextBullet)
        {
            a++;

                NextBullet = Time.time + HowOften;
            if (a <= 30)
            {
                // zeby pocisk pojawial sie w wyznaczonym miejscu
                Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            }
            if((a > 30)&&(a <= 60))
            {
                Instantiate(Bullet2, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            }
            if (a > 60)
            {
                Instantiate(Bullet3, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            }
        }
    }
}
