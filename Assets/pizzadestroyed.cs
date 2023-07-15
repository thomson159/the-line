using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzadestroyed : MonoBehaviour {

    //public float Timer;

    void Start()
    {

    }

    void Update()
    {
        //Destroy(gameObject, Timer); // niszczy sie po czasie

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            Destroy(gameObject, 0);
        }
    }
}
