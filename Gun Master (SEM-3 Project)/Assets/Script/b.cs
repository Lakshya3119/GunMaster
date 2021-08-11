using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{
    float ms = 7f;
    Rigidbody2D rb;
    public GameObject target ;
    Vector2  moved;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player");
        moved = (target.transform.position - transform.position).normalized * ms;
        rb.velocity = new Vector2(moved.x, moved.y);
        Destroy(gameObject, 3f);

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
