using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klikanie : MonoBehaviour {

    public GameObject klik;

    // Use this for initialization
    void Start ()
    {
        klik.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void KKK ()
    {
        klik.SetActive(true);
    }
}
