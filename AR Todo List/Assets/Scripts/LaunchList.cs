using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchList : MonoBehaviour
{
    private InputList _list;
    private GameObject _physicalList;
    
    void Start()
    {
        _list = GetComponentInChildren<InputList>();
        _physicalList = _list.GetPhysicalList();
    }

    public void ShowList()
    {
        if (_physicalList.activeSelf == false)
        {
        _physicalList.transform.gameObject.SetActive(true);
        }
        else
        {
            _physicalList.transform.gameObject.SetActive(false);
        }
    }
}
