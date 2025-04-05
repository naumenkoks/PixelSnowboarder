using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class CloudMovement : MonoBehaviour
{
    [SerializeField] float minSpeed = 0.5f;
    [SerializeField] float maxSpeed = 1f;

    void Update()
    {
        // Move cloud slowly to the left
        transform.Translate(Vector3.left * Random.Range(minSpeed,maxSpeed) * Time.deltaTime);
    }
}