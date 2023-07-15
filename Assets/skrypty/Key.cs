using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public int KeyScore = 1;
    public KeyMaster MasterK;

    // zmienne ktore pomagaja nam opoznic troche dodanie punktu 
    // aby dodawal sie tylko 1 punkt dla jednej monety
    // jakis bug i czasem dodaje 2 punkty jesli szybko wejdziemy w monete

    float TimeBreaker2 = 1;
    float TimeStop2;

    // WSZYSTKIE OBIEKTY MUSZA MIEC LAYER UL 

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Time.time > TimeStop2) // zapobiega bugowaniu aby dodawalo tylko
                                      // 1 monete
            {
                TimeStop2 = Time.time + TimeBreaker2;
                MasterK.AddKey(KeyScore); // przekazuje zmienna MoneyScore do
                                              // skryptu MasterM do metody AddMoney
                Destroy(gameObject, 0);
            }
        }
    }
}
