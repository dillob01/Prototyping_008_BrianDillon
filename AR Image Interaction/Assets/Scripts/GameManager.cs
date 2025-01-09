using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _HBInfoCanvas;
    [SerializeField] private GameObject _PICCInfoCanvas;
    [SerializeField] private Material _opaqueShirtMaterial;
    [SerializeField] private Material _transparentShirtMaterial;
    [SerializeField] private GameObject _HBAnatomy;
    [SerializeField] private GameObject _PICCAnatomy;
    [SerializeField] private GameObject _upperBody;
    
    public void Reset()
    {
        _HBInfoCanvas.SetActive(false);
        _PICCInfoCanvas.SetActive(false);
        _HBAnatomy.SetActive(false);
        _PICCAnatomy.SetActive(false);
        _upperBody.GetComponent<Renderer>().material = _opaqueShirtMaterial;
    }
    
    public void ShowHBInfoCanvas()
    {
        Reset();
        _HBInfoCanvas.SetActive(true);
    }

    public void ShowPiccInfoCanvas()
    {
        Reset();
        _PICCInfoCanvas.SetActive(true);
    }

    public void ShowHBExternal()
    {
        Reset();
        _HBAnatomy.SetActive(true);
    }

    public void ShowPiccExternal()
    {
        Reset();
        _PICCAnatomy.SetActive(true);
    }

    public void ShowHBInternal()
    {
        Reset();
        _HBAnatomy.SetActive(true);
        _upperBody.GetComponent<Renderer>().material = _transparentShirtMaterial;
    }

    public void ShowPiccInternal()
    {
        Reset();
        _PICCAnatomy.SetActive(true);
        _upperBody.GetComponent<Renderer>().material = _transparentShirtMaterial;
    }
}
