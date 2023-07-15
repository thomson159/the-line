using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour 
{
	Rigidbody2D RBEnemy;
	public float speed;
	public float NextShoot; // co jaki czas strzela
	float HowTime;

	public GameObject Mob;

	void Start () 
	{
		RBEnemy = GetComponent<Rigidbody2D>();
	}

	void Update () 
	{
		RBEnemy.velocity = new Vector2 (speed, 0);

		if(speed > 0) 
		{
			transform.localScale = new Vector2(-1, 1);
		}
		else
		{
			transform.localScale = new Vector2(1, 1);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Wall")
		{
			if(Time.time > HowTime)
			{
				HowTime = Time.time + NextShoot;
				speed *= -1;
			}
		}
	}
}
