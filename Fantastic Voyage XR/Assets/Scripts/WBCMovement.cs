using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBCMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 100f;
    [SerializeField] private float _rotationSpeed = 100f;
    
    void Update()
    {
        transform.Translate(-Vector3.right * _speed * Time.deltaTime, Space.World);
        
        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward, _rotationSpeed * Time.deltaTime, Space.Self);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            Destroy(gameObject);
        }
    }
}
