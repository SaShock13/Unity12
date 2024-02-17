using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{    
    [SerializeField] ParticleSystem particleSys2;    
    MeshRenderer mesh;
    Collider coll;

    
    ParticleSystem particleSys;
    AudioSource bonusSound;

    private void Awake()
    {
        coll = GetComponent<Collider>();
        mesh = GetComponent<MeshRenderer>();
        particleSys = GetComponentInChildren<ParticleSystem>();        
        bonusSound = GetComponent<AudioSource>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (particleSys!=null)
            {
                particleSys.Play(); 
                particleSys2.Stop();
                bonusSound.Play();
            }
            mesh.enabled = false;
            coll.enabled = false;
        }
    }
}
