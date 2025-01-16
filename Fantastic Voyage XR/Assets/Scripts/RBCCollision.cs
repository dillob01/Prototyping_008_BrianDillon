using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBCCollision : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6) //Wall layer is 6
        {
            _audioSource.Play();
        }
    }
}
