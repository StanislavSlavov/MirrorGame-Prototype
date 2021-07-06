using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakMirror : MonoBehaviour
{
    [SerializeField] AudioClip breakMirror;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(breakMirror);
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
}
