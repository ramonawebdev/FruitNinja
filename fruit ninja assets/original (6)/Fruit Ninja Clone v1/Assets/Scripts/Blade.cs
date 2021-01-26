﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
	private Rigidbody2D rb;


	// Use this for initialization
	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		SetBladeToMouse();
	}

	private void SetBladeToMouse()
	{
		var mousePos = Input.mousePosition;
		mousePos.z = 10; // distance of 10 units from the camera

		rb.position = Camera.main.ScreenToWorldPoint(mousePos);

	}

}
