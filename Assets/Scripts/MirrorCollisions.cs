using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCollisions : MonoBehaviour
{
    float initialHP;
    [SerializeField ]float glassHP = 6;
    [SerializeField] AudioClip hardGlass;
    [SerializeField] AudioClip crackedGlass;

    [SerializeField] GameObject mirrorBreakEffect;
    AudioSource audioSource;


    void Start() 
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        initialHP = glassHP;
    }


    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "EnemyKiller")
        {   
            glassHP --;

            if (glassHP > 0.65 * initialHP)
            {
                audioSource.PlayOneShot(hardGlass);
            }
            else if (glassHP > 0)
            {
                audioSource.PlayOneShot(crackedGlass);
            }
            else 
            {
                Instantiate(mirrorBreakEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
