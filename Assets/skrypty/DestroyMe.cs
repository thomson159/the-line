using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour {

    public float Timer;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        Destroy(gameObject, Timer); // niszczy sie po czasie

	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0); // niszczy sie po uderzeniu w inny obiekt
    }
}
