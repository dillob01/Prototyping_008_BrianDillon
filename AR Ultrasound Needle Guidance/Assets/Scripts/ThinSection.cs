using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

[ExecuteInEditMode]
public class ThinSection : MonoBehaviour
{
    [SerializeField] private Material _thinSectionMaterial;
    [SerializeField] private float _offset;
    private Vector3 _planeOffset;
    
    private void Update()
    {
        _planeOffset = transform.up * _offset;
        _thinSectionMaterial.SetVector("_Plane_Position", transform.position);
        _thinSectionMaterial.SetVector("_Plane_Position_2", transform.position + _planeOffset);
        _thinSectionMaterial.SetVector("_Plane_Normal", transform.up);
    }
}