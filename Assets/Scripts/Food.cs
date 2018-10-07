﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public int type;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            FoodGenerator.FoodDrop.Remove(gameObject);
            Destroy(gameObject);
            Bar.food += Mathf.Pow(3+Level.level/5,type)*5;
        }
    }
}
