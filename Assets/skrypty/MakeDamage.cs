using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public int Damage;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        
	}

    //void OnTriggerEnter2D(Collider2D other)
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Player2" || other.tag == "Player3" || other.tag == "Player4" || other.tag == "Player5" || other.tag == "Player6" || other.tag == "Player7" || other.tag == "Player8")
        {
            //przekazuje wartosc zmiennej do innego skryptu

           TheLineLudzik PlayerHealth = other.gameObject.GetComponent<TheLineLudzik>();
            //zwraca do metody AddDamage ze skryptu Ludek wartość zmiennej Damage
            PlayerHealth.AddDamage(Damage);
        }
    }
}
