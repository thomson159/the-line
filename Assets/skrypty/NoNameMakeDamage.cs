using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoNameMakeDamage : MonoBehaviour 
{

	public int Damage;
	public float NextDamage;
	float HowOftenDamage;
	//Rigidbody2D EnemyRB;
	//Animator MobAnimator;
	Animator anim;

	//public GameObject Mob;

	void Start ()
	{
		//MobAnimator = GetComponentInChildren<Animator>();
		//EnemyRB = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	void Update ()
	{

	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			anim.SetBool ("fight", true);

			if (Time.time > HowOftenDamage) 
			{
				HowOftenDamage = Time.time + NextDamage;
				// przekazuje wartosc zmiennej do innego skryptu
				Ludek PlayerHealth = other.gameObject.GetComponent<Ludek> ();
				// zwraca do metody AddDamage ze skryptu Ludek wartość zmiennej Damage
				PlayerHealth.AddDamage (Damage);
			} else 
			{
				//anim.SetBool ("fight", false);
			}	
		} 
	}
	void OnTriggerExit2D(Collider2D other)
	{
		anim.SetBool ("fight", false);
	}
}
