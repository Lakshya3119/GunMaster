using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class s1end : MonoBehaviour
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
            SceneManager.LoadScene(5);
            Debug.Log("ababab");
        }
    }
}
