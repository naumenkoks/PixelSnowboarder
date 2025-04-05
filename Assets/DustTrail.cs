using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class DustTrail : MonoBehaviour

{
    [SerializeField] ParticleSystem dustParticles;
    [SerializeField] float defaultSize = 0.1f;
    [SerializeField] float boostedSize = 0.3f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            StartDustTrail(); 
        }
             
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            StopDustTrail();
        }
        
    }
    
    void StartDustTrail()
    {
        dustParticles.Play();
    }
    void StopDustTrail()
    {
        dustParticles.Stop();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SetParticleSize(boostedSize);
        }
        else
        {
            SetParticleSize(defaultSize);
        }
    }

    void SetParticleSize(float size)
    {
        if (dustParticles == null) return;

        ParticleSystem.MainModule main = dustParticles.main;
        main.startSize = size;
    }
}
