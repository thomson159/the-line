using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControler : MonoBehaviour
{
    // latanie
    public float PlaneSpeed;
    // podstawowe
    Rigidbody2D RB;
    // strzelanie
    public Transform Gun;
    public GameObject Bullet;
    public float NextShoot; // co jaki czas strzela
    float HowTime;

    void Start ()
    {
        RB = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        RB.velocity = new Vector2(-PlaneSpeed, 0); // samolot leci w lewo
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        PlaneSpeed = PlaneSpeed * -1; // zmiana kierunku lotu
        if(PlaneSpeed > 0) 
        {
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            transform.localScale = new Vector2(-1, 1);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        { // zainicjowanie pojawienie sie pocisku jesli player jest w zasiegu
            if(Time.time > HowTime)
            {
                HowTime = Time.time + NextShoot;
                Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
            }
        }
    }
}