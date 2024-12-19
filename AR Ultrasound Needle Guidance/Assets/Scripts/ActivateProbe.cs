using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateProbe : MonoBehaviour
{
    [SerializeField] private RawImage _textImage;
    [SerializeField] private Light _screenLight;
    [SerializeField] private Light _probeLight;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Probe")) return;
        
        _textImage.enabled = false;
        _screenLight.color = Color.green;
        _probeLight.color = Color.green;
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Probe")) return;
        
        _textImage.enabled = true;
        _screenLight.color = Color.red;
        _probeLight.color = Color.red;
    }
}
