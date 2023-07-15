using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheLineLudzik : MonoBehaviour
{
    //WYLACZAM PODBIJANIE POSTACI NA POTRZEBY EDUKACYJNE PAMIETAC WLACZYC !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    //public GameObject animred;

    public GameObject PauseUL;
    public bool pause = false;

    public GameObject musicskok;

    public GameObject music;

    // podstawowe
    Rigidbody2D RB;
    Animator anim;

    // skakanie
    public float HightJump;
    public Transform GroundCheck; // "Ground" przypisanie znacznika pod nogami postaci
    public LayerMask GroundLayer; // zdefiniowanie powierzchni na ktorej postac moze skakac
    float GroundCheckRadius = 0.2f; // nie wiadomo co zmienia
    bool grounded = false;

    //strzelanie
    public Transform Gun;
    public GameObject Bullet;
    public float HowOften; // co ile moze strzelac
    public float NextBullet;

    public float HowOften2; // co ile moze strzelac
    public float NextBullet2;

    public GameObject Bullet2;

    // zycie gracza
    public int MaxHealth = 3;
    public float NextDamage;
    float HowOftenDamage;

    public GameObject Blood;

    public int czas;

    //private MoneyMaster Wy;

    //public static TheLineLudzik Instance {set; get;}

    void Start ()
    {
        musicskok.SetActive(false);
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        PauseUL.SetActive(false);
        pause = false;

        music.SetActive(true);
    }
    
    public float costam = 0; 

    void Update ()
    {
        czas++;
        if (czas < 1000)
        {
            Time.timeScale = Time.timeScale + 0.0003f;
            costam = czas;
        }
    }
    public float dupa = 0;
    public bool tak2 = false;
    
    void FixedUpdate()
    {
        if (tak2 == true)
        {
            dupa++;
        }
        if (dupa == 10)
        {
            musicskok.SetActive(false);
            tak2 = false;
            dupa = 0;
        }
        //Time.timeScale = Time.timeScale + 0.0003f;

        bool grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);

        if (Input.GetAxis("Jump") > 0.1f && grounded == true)
        {
            RB.velocity = new Vector2(0, HightJump);

            musicskok.SetActive(true);
            tak2 = true;
        }

        if (Input.GetMouseButtonDown(0) && grounded == true || Input.touchCount > 0 && grounded == true)
        {
            RB.velocity = new Vector2(0, HightJump);

            musicskok.SetActive(true);
            tak2 = true;
        }


        anim.SetBool("skakanie", grounded);
        anim.SetFloat("skakaniedrzewo", RB.velocity.y);

        //if (Input.GetAxis("Fire1") > 0.1f)
        //{
        //    GunShoot();
        //}

        //if (Input.GetAxis("Fire2") > 0.1f)
        //{
        //    GunShoot2();
        //}
        
    }
    
    //public void Jump()
    //{
    //    musicskok.SetActive(true);
    //    tak2 = true;
    //    bool grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);

    //    if (grounded == true)
    //    {
    //        RB.velocity = new Vector2(0, HightJump);
    //    }
    //}

    public void Shoot()
    {
        GunShoot();
    }

    public void UsePower()
    {
        GunShoot2();
    }

    void GunShoot()
    {
        //zorientowac sie o co chodzi z komenda Quaternion.Euler
        if (Time.time > NextBullet)
        {
            NextBullet = Time.time + HowOften;
            //zeby pocisk pojawial sie w wyznaczonym miejscu
            Instantiate(Bullet, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
        }
    }

    void GunShoot2()
    {
        //zorientowac sie o co chodzi z komenda Quaternion.Euler
        if (Time.time > NextBullet2)
        {
            NextBullet2 = Time.time + HowOften2;
            //zeby pocisk pojawial sie w wyznaczonym miejscu
            Instantiate(Bullet2, Gun.position, Quaternion.Euler(new Vector2(0, 0)));
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
            //RB.velocity = new Vector2(0, 80);
            //SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            //renderer.color = new Color(150f, 0f, 0f, 255f);
            
            //animred.GetComponent<Animation>().Play("player_RedFlash");
            
            if (MaxHealth == 0)
            {
                MakeDead();
                //pause = true;
            }
        }
        //else
        //{
        //    //SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        //    //renderer.color = new Color(255f, 255f, 255f, 255f);
        //}
    }
    
    void MakeDead()
    {
        Destroy(gameObject);
        Instantiate(Blood, transform.position, Quaternion.identity);

        PauseUL.SetActive(true);
        Time.timeScale = 1;

        music.SetActive(false);
    }
}
