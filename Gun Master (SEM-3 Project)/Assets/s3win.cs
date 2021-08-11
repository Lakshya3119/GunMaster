using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class s3win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == cube)
        {
            SceneManager.LoadScene(6);
            Debug.Log("ababab");
        }
    }
}
