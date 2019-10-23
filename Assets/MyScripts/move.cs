using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class move : MonoBehaviour
{
	Rigidbody2D rb;
	float dirX;
	
	[SerializeField]
	float moveSpeed = 5f, jumpforce = 600f, bulletSpeed = 500f;
	
	Vector3 localScale;
	
	public Transform barrel;
	public Rigidbody2D bullet;
	public GameObject wonGamePanel;

    void Start()
    {
		Time.timeScale = 1;
        localScale = transform.localScale;
		rb = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {	
        dirX = CrossPlatformInputManager.GetAxis ("Horizontal");
		
		if (CrossPlatformInputManager.GetButtonDown ("Jump"))
			Jump ();
		
		if (CrossPlatformInputManager.GetButtonDown ("Fire1"))
			Fire();
    }
	void FixedUpdate()
	{
		rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
	}
	
	void Jump()
	{
		if (rb.velocity.y == 0)
			rb.AddForce (Vector2.up * jumpforce);
	}
	
	void Fire()
	{
		var firedBullet = Instantiate (bullet, barrel.position, barrel.rotation);
		firedBullet.AddForce (barrel.up * bulletSpeed);
	}
	
	    void OnTriggerEnter2D(Collider2D target)
	{
		if (target.CompareTag("Coin"))
		{
			wonGamePanel.SetActive (true);
			Destroy (target.gameObject);
			Debug.Log ("Tresure");
			Time.timeScale = 0;
		}
	}
}
