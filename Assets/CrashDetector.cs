using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip CrashSound;
    [SerializeField] bool isAlive = true;
    void OnTriggerEnter2D(Collider2D other) 
    
    {
        if(other.tag == "Ground" && isAlive)
        {
            FindAnyObjectByType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(CrashSound);
            Invoke("ReloadScene", restartDelay);
            isAlive = false;
        }
          
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
 
}
