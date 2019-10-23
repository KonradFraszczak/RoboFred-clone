using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	Rigidbody2D rb;
	
    void OnCollisionEnter2D(Collision2D target)
	{
		if (target.transform.CompareTag("Bullet"))
		{
			Destroy (this.gameObject);
		}
	}
}
