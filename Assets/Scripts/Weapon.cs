using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
     [SerializeField] float fireRate = 1f;
    float nextFire;
    [SerializeField] Transform shootingPoint;
    [SerializeField] GameObject shootPrefab;
    AudioSource audioSource;
    [SerializeField] AudioClip shootSFX;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nextFire = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckTimeToFire();
    }

    void Shoot()
    {
        Instantiate(shootPrefab, shootingPoint.position, shootingPoint.rotation);
    }

    void CheckTimeToFire()
    {
        if (Time.time > nextFire)
        {   
            nextFire = Time.time + fireRate;
            audioSource.PlayOneShot(shootSFX);
            Shoot();
        }
    }
}
