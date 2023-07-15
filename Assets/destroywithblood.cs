using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywithblood : MonoBehaviour
{

    public float Timer;

    public GameObject Bullet;

    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, Timer); // niszczy sie po czasie

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
