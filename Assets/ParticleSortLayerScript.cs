using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSortLayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Foreground";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
