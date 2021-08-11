using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharacterController2D controller;
    Rigidbody2D rb;

    public float runspeed = 40f;
    float HorizontalMove = 10f;
    bool Jump = false;
    private bool facingright;

    // Start is called before the first frame update
    void Start()
    {
        facingright = true;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    public void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(runspeed * move, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            soundmanagerScript.PlaySound("jump");
            transform.Translate(Vector3.up * 150 * Time.deltaTime, Space.World);
            Jump = true;
            animator.SetBool("IsJumping", true);

        }


    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(runspeed * move, rb.velocity.y);
        Flip(HorizontalMove);
    }
    private void Flip(float HorizontalMove)
    {
        if (HorizontalMove > 0 && !facingright || HorizontalMove < 0 && facingright)
        {
            facingright = !facingright;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;

            transform.localScale = theScale;

        }
    }
}
