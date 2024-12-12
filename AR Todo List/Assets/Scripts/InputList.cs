using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputList : MonoBehaviour
{
    [SerializeField] private String _title;
    [SerializeField] private List<String> _items;
    [SerializeField] private GameObject _physicalListPrefab; //Prefab for vertical canvas
    [SerializeField] private GameObject _newListTogglePrefab; //Prefab for vertical canvas toggle
    
    private GameObject _physicalList; //Vertical canvas with toggles
    private Transform _listContentAttachPoint; //Attach point for new toggles

    private void Awake()
    {
        FillPhysicalList();
    }

    private void FillPhysicalList()
    {
        //Intantiate new physical list(vertical canvas)
        _physicalList = Instantiate(_physicalListPrefab);
        
        //Assign the title to the physical list
        _physicalList.GetComponentInChildren<TextMeshProUGUI>().text = _title; //Works because title is first child with TMP

        //Use CanvasAttachPoint to determine location to add new toggles
        _listContentAttachPoint = _physicalList.GetComponent<CanvasContentAttachPoint>().GetContentAttachPoint();
        
        //Add list toggles
        for (int i = 0; i < _items.Count; i++)
        {
            GameObject _newToggle = Instantiate(_newListTogglePrefab, _listContentAttachPoint);
            
            //Assign item text
            _newToggle.GetComponentInChildren<TextMeshProUGUI>().text = _items[i];
        }
    }
    
    public String GetTitle()
    {
        return _title;
    }

    public GameObject GetPhysicalList()
    {
        return _physicalList;
    }
}