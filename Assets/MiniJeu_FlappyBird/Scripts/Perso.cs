using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour
{

	public float force; // force du saut
	private bool mort = false; // Notre personnage est-il en vie

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0) && !mort)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(0f, force);
			transform.rotation = Quaternion.RotateTowards(Quaternion.Euler(0f, 0f, 0f), Quaternion.Euler(0f, 0f, 90f), GetComponent<Rigidbody2D>().velocity.y * 0.5f);
		}
		else if (GetComponent<Rigidbody2D>().velocity.y < -0.05)
		{
			transform.rotation = Quaternion.RotateTowards(Quaternion.Euler(0f, 0f, 0f), Quaternion.Euler(0f, 0f, 270f), -GetComponent<Rigidbody2D>().velocity.y);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Perdre();
	}

	void Perdre()
	{
		mort = true;
		Game.perdu = true;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
			Game.score++;
	}
    

}
