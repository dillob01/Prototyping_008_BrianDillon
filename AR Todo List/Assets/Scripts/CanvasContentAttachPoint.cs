using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasContentAttachPoint : MonoBehaviour
{
    [SerializeField] private Transform _contentAttachPoint;

    //Returns the transform of the "Content" child of the canvas, where new toggles are added
    public Transform GetContentAttachPoint()
    {
        return _contentAttachPoint;
    }
}
