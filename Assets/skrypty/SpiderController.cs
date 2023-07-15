using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderController : MonoBehaviour 
{
	Rigidbody2D RB;
	public float SpiderSpeed;
	float NextBullet;
	public float HowOften;

	public GameObject Mob;

	void Start () 
	{
		RB = GetComponent<Rigidbody2D> ();
	}

	void Update () 
	{
		
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
				RB.velocity = new Vector2 (0, -SpiderSpeed);
		} 
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			RB.velocity = new Vector2 (0, SpiderSpeed);
		} 
	}
}
