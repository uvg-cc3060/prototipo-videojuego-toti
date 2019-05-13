using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
	public float velocidad = 10; 
	private Rigidbody miRigidbody;
	
	// Use this for initialization
	void Start ()
	{
		miRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float vertical = Input.GetAxis("Vertical");
		float horizonal = Input.GetAxis("Horizontal");
		miRigidbody.AddForce(new Vector3(horizonal, 0, vertical)*velocidad);
	}
}
