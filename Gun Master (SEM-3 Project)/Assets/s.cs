﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision Col)
    {

        if (Col.gameObject.name == "3")
        {

            Debug.Log("asdads");

           Destroy(Col.gameObject);
        }
    }
}
