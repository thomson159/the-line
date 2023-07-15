using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController3 : MonoBehaviour
{

    Rigidbody2D RB;
    public float BulletSpeed3; // predkosc pocisku
    private static bool Flip; // zadeklarowanie wartosci z innego skryptu
    // players damage
    public int PlayerDamage;

    void Start()
    {

    }

    void Update()
    {

    }

    void Awake()

    // dzieki metodzie Awake pocisk porusza sie tylko wzgledem 
    // parametru ktory otrzyma na poczatku, pozniej tego parametru nie 
    // nie da sie zmienic

    // Update - pocisk po wystrzeleniu zmienia kierunek lotu jesli player
    // zmieni kierunek w ktorym sie porusza
    // poniewaz Update dziala podkladkowo

    // Awake - pocisk zostaje wystrzelony i bedzie poruszal sie w odpowienim
    // kierunku do samego konca

    // W metodzie Awake musi byc zadeklarowany RB

    // Metoda Awake idealnie sie sprawdza w strzalach wybuchach

    {
        RB = GetComponent<Rigidbody2D>();
        Flip = Ludek.flip;   //zaciagniecie wartosci z innego skryptu
        //// pocisk leci w prawo
        if (Flip == false)
        {
            RB.velocity = new Vector2(BulletSpeed3, 0);
			transform.localScale = new Vector2 (-1, 1);
        }
        //// w lewo
        if (Flip == true)
        {
            RB.velocity = new Vector2(-1 * BulletSpeed3, 0);
			transform.localScale = new Vector2 (1, 1);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.isTrigger && col.CompareTag("Enemy"))
        {
            col.SendMessageUpwards("PlayerMakeDamage", PlayerDamage);
        }
    }
}
