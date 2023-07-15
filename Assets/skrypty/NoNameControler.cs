using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoNameControler : MonoBehaviour
{
    Rigidbody2D EnemyRB;
    Animator MobAnimator;

	public GameObject Mob;

    public float Speed;
    bool Facing = true;

    public Transform GroundCheck; // "Ground" przypisanie znacznika pod nogami postaci
    public LayerMask GroundLayer; // zdefiniowanie powierzchni na ktorej postac moze skakac
    float GroundCheckRadius = 0.2f;

    public bool grounded;

    //public Transform Gun;
    //public GameObject Bullet;
    //public float NextShoot; // co jaki czas strzela
    //float HowTime;

    void Start ()
    {
        //RB = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
		MobAnimator = GetComponentInChildren<Animator>();
		EnemyRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //if (Time.time > HowTime)
        //{
        //    HowTime = Time.time + NextShoot;
        //    Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
        //}
    }

    void OnTriggerEnter2D(Collider2D col)
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        bool grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);
        if (other.tag == "Player" && grounded == true)
        {
			MobAnimator.SetBool("run", true);
            if (Facing && other.transform.position.x < transform.position.x)
            {
				//EnemyRB.AddForce(new Vector2(-1, 0) * Speed);
				EnemyRB.velocity = new Vector2(-Speed, 0);
				transform.localScale = new Vector2(1, 1);
            }
            else
            {
				EnemyRB.velocity = new Vector2(Speed, 0);
                transform.localScale = new Vector2(-1, 1);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
			EnemyRB.velocity = new Vector2(0f, 0f);
            grounded = false;
			MobAnimator.SetBool("run", false);
        }
    }
}
