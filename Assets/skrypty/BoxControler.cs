using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControler : MonoBehaviour
{
    //zycie
    public int HealthEnemy;
    //drop
    public Transform WhereDrop;
    public GameObject DropMoney;
    public GameObject DropKey;
    public GameObject DropHeart;
    // podstawowe
    Rigidbody2D RB;
    // losowanie liczby
    int MemberRandom;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public void PlayerMakeDamage(int Damage)
    {
        HealthEnemy = HealthEnemy - Damage;
        if (HealthEnemy <= 0)
        {
            Destroy(gameObject);
            MemberRandom = Random.Range(0, 3);
            if (MemberRandom == 1)
            {
                Instantiate(DropMoney, WhereDrop.position, Quaternion.Euler(new Vector2(0, 0)));
            }
            if (MemberRandom == 2)
            {
                Instantiate(DropKey, WhereDrop.position, Quaternion.Euler(new Vector2(0, 0)));
            }
            if (MemberRandom == 3)
            {
                Instantiate(DropHeart, WhereDrop.position, Quaternion.Euler(new Vector2(0, 0)));
            }
        }
    }
}
