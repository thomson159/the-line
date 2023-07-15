using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyMaster : MonoBehaviour
{

    int Key = 0;
    public Text KeyText;

    // WSZYSTKIE OBIEKTY MUSZA MIEC LAYER UL 

    void Start()
    {

    }

    void Update()
    {
        KeyText.text = "" + Key; // wyswietla wynik 
    }

    public void AddKey(int Score) // sumuje monety, wykozystuje zmienna Score
                                    // ze skryptu Money 
    {
        Key += Score;
    }
}
