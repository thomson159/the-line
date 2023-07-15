using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tntboom : MonoBehaviour {

    public float Timer;

    public GameObject Bullet;
    public GameObject Bullet2;
    public GameObject Bullet3;

    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, Timer); // niszczy sie po czasie

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "Bullet")||(other.tag == "Player"))
        {
            Destroy(gameObject);
            Instantiate(Bullet, transform.position, Quaternion.identity);
            Instantiate(Bullet2, transform.position, Quaternion.identity);
            Instantiate(Bullet3, transform.position, Quaternion.identity);
        }
    }
}
