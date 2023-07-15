using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDownController : MonoBehaviour
{

	Rigidbody2D RB;
	// predkosc pocisku
	public float BulletSpeed2;
	// players damage
	public int PlayerDamage;

	void Start()
	{
		RB = GetComponent<Rigidbody2D>();

	}

	void Update()
	{
		// pocisk leci do gory
		RB.velocity = new Vector2(0, -BulletSpeed2);
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (!col.isTrigger && col.CompareTag("Enemy"))
		{
			col.SendMessageUpwards("PlayerMakeDamage", PlayerDamage);
		}
	}
}
