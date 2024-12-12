using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private ListOfInputLists _inputLists; //List of input lists
    [SerializeField] private GameObject _newMenuTogglePrefab; //Horizontal menu toggle prefab
    private Transform _menuContentAttachPoint; //Transform where new toggles are attached
    
    void Awake()
    {
        GenerateMenu();
    }

    private void GenerateMenu()
    {
        //Use CanvasAttachPoint to determine location to add new toggles
        _menuContentAttachPoint = GetComponentInChildren<CanvasContentAttachPoint>().GetContentAttachPoint();
        
        InputList[] _lists = _inputLists.GetInputLists();
        for (int i = 0; i < _lists.Length; i++)
        {
            //Add menu toggles
            GameObject _newToggle = Instantiate(_newMenuTogglePrefab, _menuContentAttachPoint);
            
            //Add title to toggle
            _newToggle.GetComponentInChildren<TextMeshProUGUI>().text = _lists[i].GetTitle();
            
            //Set list as child of toggle
            _lists[i].transform.SetParent(_newToggle.transform);

            //Add toggle to togggle group to allow switching
            _newToggle.GetComponent<Toggle>().group = _menuContentAttachPoint.GetComponent<ToggleGroup>();
        }
    }
}