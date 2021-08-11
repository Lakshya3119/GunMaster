using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanagerScript : MonoBehaviour

    
{
    public static AudioClip jumpsound, firesound, enemydeathsound, playerdeathsound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        jumpsound = Resources.Load<AudioClip>("jump");
        firesound = Resources.Load<AudioClip>("fire");
        enemydeathsound = Resources.Load<AudioClip>("enemydeath");
        playerdeathsound = Resources.Load<AudioClip>("playerdeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSrc.PlayOneShot(firesound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpsound);
                break;
            case "enemydeath":
                audioSrc.PlayOneShot(enemydeathsound);
                break;
            case "playerdeath":
                audioSrc.PlayOneShot(playerdeathsound);
                break;
        }
       
    }
}
