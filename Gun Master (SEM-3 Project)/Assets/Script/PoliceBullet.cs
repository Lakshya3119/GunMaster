using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceBullet : MonoBehaviour
{
    public GameObject c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == c)
        {
            
            Destroy(gameObject);
            Debug.Log("lund");
            Destroy(c);
        }
    }
}
