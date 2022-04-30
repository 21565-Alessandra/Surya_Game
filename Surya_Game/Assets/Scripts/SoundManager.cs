using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip catchSound, meteorSound, winSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        catchSound = Resources.Load<AudioClip>("catch");
        meteorSound = Resources.Load<AudioClip>("meteorSound");
        winSound = Resources.Load<AudioClip>("win");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "catch":
                audioSrc.PlayOneShot (catchSound);
                break;
            case "meteorSound":
                audioSrc.PlayOneShot (meteorSound);
                break;
            case "win":
                audioSrc.PlayOneShot (winSound);
                break;            
        }
    }
}
