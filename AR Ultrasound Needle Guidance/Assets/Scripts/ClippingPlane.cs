using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

[ExecuteInEditMode]
public class CrossSectionPlane : MonoBehaviour
{
    [SerializeField] private Material _crossSectionMaterial;
    
    private void Update()
    {
        _crossSectionMaterial.SetVector("_planePosition", transform.position);
        _crossSectionMaterial.SetVector("_planeNormal", transform.up);
    }
}