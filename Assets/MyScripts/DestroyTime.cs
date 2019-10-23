using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour
{
	[SerializeField]
	float destroyTime = 2f;
	
	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.CompareTag("Enemy"))
		{
			Destroy (target.gameObject);
			Debug.Log ("Hit");
		}
	}

    void Update()
    {
        Destroy (gameObject, destroyTime);
    }
	
	
}
