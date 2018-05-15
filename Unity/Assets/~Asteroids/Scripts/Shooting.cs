using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bulletPrefab; // Prefab of bullet to spawn
    public float bulletSpeed = 20f; // Speed that the bullet travels
    public float shootRate = 0.2f; // Rate of fire (in seconds)

    private float shootTimer = 0f; // Timer to count up to shoort time

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Shoot()
    {
        // Create a new bullet clone 
        GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
        // Grab rigidboy from clone
        Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
        // Add a force to the bullet (using bulletSpeed) 
        rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
