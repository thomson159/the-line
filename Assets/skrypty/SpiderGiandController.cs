using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderGiandController : MonoBehaviour
{
	public GameObject Bullet;
	public Transform Gun;
	public GameObject Bullet2;
	public Transform Gun2;
	public float NextShoot; // co jaki czas strzela
	float HowTime;

	void Start () 
	{
		
	}
	

	void Update ()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{ // zainicjowanie pojawienie sie pocisku jesli player jest w zasiegu
			if(Time.time > HowTime)
			{
				HowTime = Time.time + NextShoot;
				Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
				Instantiate(Bullet2, Gun2.position, Quaternion.Euler(new Vector2(0, 0)));

			}
		}
	}
}
