using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int HealthEnemy;
    public Transform Gun;
    public GameObject Bullet;
    public Transform Gun2;
    public GameObject Bullet2;

	public GameObject mobek;

	float HowOftenDamage; 
	float NextDamage = 1;

	Animator anim;
	Rigidbody2D RB;

    void Start ()
    {
		anim = GetComponent<Animator> ();
		RB = GetComponent<Rigidbody2D> ();
	}
	
	void Update ()
    {
		
	}

    public void PlayerMakeDamage(int damage)
    {
        HealthEnemy = HealthEnemy - damage;

        if (HealthEnemy <= 0)
        {
            DeadEnemy();
			//anim.SetBool ("dead", true);
        }
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		SpriteRenderer SR = GetComponent<SpriteRenderer> ();
		if (other.tag == "Bullet") 
		{
			SR.color = new Color (255f, 0f, 0f, 255f);
		} 
		else 
		{
			SR.color = new Color (255f, 255f, 255f, 255f);
		}
	}

    public void DeadEnemy()
    {
        Destroy(mobek.gameObject);
		Destroy (gameObject);
        Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
        Instantiate(Bullet2, Gun2.position, Quaternion.Euler(new Vector2(0, 0)));
    }
}
