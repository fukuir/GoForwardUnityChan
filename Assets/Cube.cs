﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }
        if (other.gameObject.tag == "UniTag")
        {
            Destroy(other.gameObject);
        }
    }
}
