using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    AudioSource sound;

    private void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    public void JumpSound()
    {
        sound.Play();
    }
}
