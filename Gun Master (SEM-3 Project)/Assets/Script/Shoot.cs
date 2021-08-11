using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public float bulletVelocity = 5f;
    public GameObject bullet;
    public GameObject bullet1;
    public int damage;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            soundmanagerScript.PlaySound("fire");
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();
            // Creates the bullet locally
            GameObject bullet = (GameObject)Instantiate(
                                    bullet1,
                                    transform.position + (Vector3)(direction * 0.5f),
                                    Quaternion.identity);
            // Adds velocity to the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;

        }

    }
    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Enemy enemy = hitinfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
        Debug.Log("lund");
    }
}

