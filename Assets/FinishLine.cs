using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float restartDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioSource finishSFX;
void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            finishSFX.Play(); 
            Invoke("ReloadScene", restartDelay);  
        }
          
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
    