using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchwaController : MonoBehaviour
{
    Rigidbody2D RB;
    int OsX = 30;
    int OsY = 30;
    int Rotatio = 3;

    void Start ()
    {
        RB = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        transform.Rotate(Vector3.forward * Rotatio); 
        RB.velocity = new Vector2(OsX, OsY);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player")
        {
            OsX = OsX * -1;
            OsY = OsY * 1;
            Rotatio = Rotatio * -1;
        }
        else
        {
            OsX = OsX * 1;
            OsY = OsY * -1;
        }
    }
}
