using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public float CH { get; set; }
    public float MH { get; set; }

    public Slider healthbar;

    // Start is called before the first frame update
    void Start()
    {
        MH = 100f;
        CH = MH;
        healthbar.value = CalculatedHealth();


    }

    // Update is called once per frame
    void Update()
    {
        
            
    }
    void DealDamage(float damageValue)
    {
        CH -= damageValue;
        healthbar.value = CalculatedHealth();

        if (CH <= 0)
            Die();

    }
    float CalculatedHealth()
    {
        return CH / MH;

    }
    void Die()
    {
        
        CH = 0;
        Destroy(GameObject.FindWithTag("Player"));
        soundmanagerScript.PlaySound("playerdeath");
        SceneManager.LoadScene(5);


    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "eb")
        {
            Debug.Log("q");
            DealDamage(15);
            Destroy(GameObject.FindWithTag("eb"));

        }


    }
}
