﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
	public GameObject jugador;
	private Vector3 distancia;
	
	// Use this for initialization
	void Start ()
	{
		distancia = transform.position - jugador.transform.position;
	}	
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = jugador.transform.position + distancia;
	}
}
