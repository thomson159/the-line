using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money2 : MonoBehaviour
{
    public int MoneyScore = 1;
    public MoneyMaster2 MasterM;

    // zmienne ktore pomagaja nam opoznic troche dodanie punktu 
    // aby dodawal sie tylko 1 punkt dla jednej monety
    // jakis bug i czasem dodaje 2 punkty jesli szybko wejdziemy w monete

    float TimeBreaker = 1;
    float TimeStop;

    // WSZYSTKIE OBIEKTY MUSZA MIEC LAYER UL 

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        //if (other.tag == "Player")
        //{
            if (Time.time > TimeStop) // zapobiega bugowaniu aby dodawalo tylko
                                      // 1 monete
            {
                TimeStop = Time.time + TimeBreaker;
                MasterM.AddMoney(MoneyScore); // przekazuje zmienna MoneyScore do
                                              // skryptu MasterM do metody AddMoney
                Destroy(gameObject, 0);
            }
        //}
    }
}
