using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dzialodziament : MonoBehaviour
{

    public Transform Gun;
    public GameObject Bullet;

    public float HowOften; // co ile moze strzelac
    public float NextBullet;

    Rigidbody2D RB;
    Animator anim;

    float los;
    float ra;

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
    void FixedUpdate()
    {
        if (Time.time > NextBullet)
        {
            NextBullet = Time.time + HowOften;
            Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
        }
    }

}
