using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ludek : MonoBehaviour {

    // chodzenie
    public float SpeedRun;

    // podstawowe
    Rigidbody2D RB;
    Animator anim;

    // skakanie
    public float HightJump;
    public Transform GroundCheck; // "Ground" przypisanie znacznika pod nogami postaci
    public LayerMask GroundLayer; // zdefiniowanie powierzchni na ktorej postac moze skakac
    float GroundCheckRadius = 0.2f; // nie wiadomo co zmienia
    bool grounded = false;

    // strzelanie
    public Transform Gun;
    public GameObject Bullet;
    public float HowOften; // co ile moze strzelac
    float NextBullet;

    // strzelanie w przeciwnym kierunku niz poruszanie sie postaci
    public Transform Gun3;
    public GameObject Bullet3;
    public float HowOften3; // co ile moze strzelac
    float NextBullet3;

    // strzelanie w góre
    public Transform Gun2;
    public GameObject Bullet2;
    public float HowOften2; // co ile moze strzelac
    float NextBullet2;

    // kierunek postaci
    public static bool flip = true;

    // zycie gracza
    public int MaxHealth = 6;
    public float NextDamage;
    float HowOftenDamage;
    // zycie gracza - serduszka u gory ekranu

    // dodatkowe zmienne
	bool CantJump = true;

	// unik
	public float blinkdistance;
	//float blink;

    void Start ()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
       
    }

    void FixedUpdate () //wykonuje sie w 0.2 s czyli praktycznie zawsze
    {
        // chodzenie postaci
        float move = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(move * SpeedRun, RB.velocity.y);
        anim.SetFloat("ludek_chodzenie", Mathf.Abs(move)); // Mathf.Abs sluzy do zmiany wartosci na dodatnia
        
        // zmiana kierunku postaci
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector2(-1, 1);
            flip = false;
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector2(1, 1);
            flip = true;
        }
        
        // skakanie postaci
        bool grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);
		if (Input.GetAxis("Jump") > 0.1f && grounded == true)
        {
            RB.velocity = new Vector2(0, HightJump);
        }
        //if (move == 0)
        //{
            anim.SetBool("ludek_skakanie", grounded);
            anim.SetFloat("skakanie_tree", RB.velocity.y);
        //}
        //else if (move > 0 || move < 0)
        //{
        //    anim.SetBool("ludek_skakanie_w_dal", grounded);
        //    anim.SetFloat("skakanie_tree2", RB.velocity.y);
        //}
        /////////////////strzelanie w prawo///////////////////
        // jesli ide w prawa strone
        if (Input.GetAxis("Fire1") > 0.1f && flip == true)
        {
            if (Input.GetAxis("Fire3") == 0f)
            {
                if (Input.GetAxis("Fire2") == 0f)
                {
                    //anim.SetBool("ludek_strzela_w_miejscu", true);
                    GunShoot();
                }
            }
        }
        else
        {
            //anim.SetBool("ludek_strzela_w_miejscu", false);
        }
        /////////////////strzelanie w lewo///////////////////
        // jesli ide w lewa strone
        if (Input.GetAxis("Fire3") > 0.1f && flip == false)
        {
            if (Input.GetAxis("Fire1") == 0f)
            {
                if (Input.GetAxis("Fire2") == 0f)
                {
                    //anim.SetBool("ludek_strzela_w_miejscu", true);
                    GunShoot();
                }
            }
        }
        else
        {
            //anim.SetBool("ludek_strzela_w_miejscu", false);
        }
        /////////strzelanie w prawo przeciwny kierunek/////////////
        // jesli ide w lewa strone
        if (Input.GetAxis("Fire1") > 0.1f && flip == false)
        {
            if (Input.GetAxis("Fire3") == 0f)
            {
                if (Input.GetAxis("Fire2") == 0f)
                {
                    GunShoot3();
                }
            }
        }
        else
        {

        }
        //////////strzelanie w lewo przeciwny kierunek/////////////
        // jesli ide w prawa strone
        if (Input.GetAxis("Fire3") > 0.1f && flip == true)
        {
            if (Input.GetAxis("Fire1") == 0f)
            {
                if (Input.GetAxis("Fire2") == 0f)
                {
                    GunShoot3();
                }
            }
        }
        else
        {

        }
        /////////////////strzelanie do gory///////////////////
        if (Input.GetAxis("Fire2") > 0.1f)
        {
            if (Input.GetAxis("Fire1") == 0f)
            {
                if (Input.GetAxis("Fire3") == 0f)
                {
                    GunShoot2();
                }
            }
        }
        else
        {

        }

		if (Input.GetAxis("Blink") > 0.1f) 
		{
			Blink ();
		}
    }

    // strzelanie postaci deklarowanie
    void GunShoot()
    {
        // zorientowac sie o co chodzi z komenda Quaternion.Euler
        if (Time.time > NextBullet)
        {
            NextBullet = Time.time + HowOften;
            // zeby pocisk pojawial sie w wyznaczonym miejscu
            Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
        }
    }
    // strzelanie w przeciwnym kierunku niz poruszanie sie postaci
    void GunShoot3()
    {
        // zorientowac sie o co chodzi z komenda Quaternion.Euler
        if (Time.time > NextBullet3)
        {
            NextBullet3 = Time.time + HowOften3;
            // zeby pocisk pojawial sie w wyznaczonym miejscu
            Instantiate(Bullet3, Gun3.position, Quaternion.Euler(new Vector2(0, 0)));
        }
    }
    // strzelanie w gore
    void GunShoot2()
    {
        // zorientowac sie o co chodzi z komenda Quaternion.Euler
        if (Time.time > NextBullet2)
        {
            NextBullet2 = Time.time + HowOften2;
            // zeby pocisk pojawial sie w wyznaczonym miejscu
            Instantiate(Bullet2, Gun2.position, Quaternion.Euler(new Vector2(0, 0)));
        }
    }

    // zadawanie obrazen postaci
    public void AddDamage(int MakeDamage) // do metody AddDamage metoda MakeDamage
    // przekazuje wartosc int ze zmiennej Damage, AddDamage musi być public
    {
        if (Time.time > HowOftenDamage)
        {
            HowOftenDamage = Time.time + NextDamage;
            MaxHealth = MaxHealth - MakeDamage;
            if (MaxHealth == 0)
            {
                MakeDead();
            }
        }
    }
    void MakeDead()
    {
        SceneManager.LoadScene(0);// respi postac, laduje scene nr 0
    }

	void Blink()
	{
		transform.position = new Vector2(blinkdistance, 0);
		
	}
}
