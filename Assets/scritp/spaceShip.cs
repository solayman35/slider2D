﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShip : MonoBehaviour 
{
	
	public float speed = .1f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(speed, 0f, 0f);
        //asdasdasd
	}

	public void OnCollision2D(Collision2D collision) {
		Destroy(gameObject);
	}
}
