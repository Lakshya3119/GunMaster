using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public  Animation anim_Walk;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim_Walk = GetComponent<Animation>();

    }

    void Update()
    {
        
    }
    public void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

    }
}
