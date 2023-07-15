using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolcepromien : MonoBehaviour
{
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject, 0);
        }
    }

}
