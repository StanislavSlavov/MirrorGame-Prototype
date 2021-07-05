using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] float fireRate = 1f;
    float nextFire;
    bool alreadyShot = false;
    int shotsFired;
    [SerializeField] Transform shootingPoint;
    [SerializeField] GameObject shootPrefab;

    // Start is called before the first frame update
    void Start()
    {
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
            Shoot();
            shotsFired ++;
            Debug.Log(shotsFired);    
        }
    }
}
