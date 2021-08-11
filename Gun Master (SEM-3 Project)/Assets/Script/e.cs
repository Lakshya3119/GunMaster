using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e : MonoBehaviour
{
    public GameObject bullet;
    public float fireR;
    public float nextF;
    public Vector3 target;
    public Transform target1;

    // Start is called before the first frame update
    void Start()
    {
     


        fireR = 3f;
        nextF = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckT();

    }
    void CheckT()
    {
        if (Time.time>nextF)
        {
            soundmanagerScript.PlaySound("fire");
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextF = Time.time + fireR;

        }
    }
}
