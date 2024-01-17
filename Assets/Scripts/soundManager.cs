using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource coinsSource;
    public AudioClip coinSound;
public AudioClip gameOverSound;

    private void Awake(){
        instance = this;
    }

    void Start()
    {
        coinsSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
