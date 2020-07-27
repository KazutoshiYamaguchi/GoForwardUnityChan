using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ObjectCollidingSound : MonoBehaviour
{

    // Use this for initialization


    public AudioClip impact;
    AudioSource audioSource;
    GameObject unitychan;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        unitychan = GameObject.Find("UnityChan2D");
    }

    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == unitychan)
        {
            Debug.Log("Accidentallly Hit! But,NoSound.");
        }
        else
        {
           audioSource.PlayOneShot(impact);
        }
        
    }

}
