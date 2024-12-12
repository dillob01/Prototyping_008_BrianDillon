using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UI.Toggle;

public class ExperienceManager : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private ListOfInputLists _inputLists;
    
    private void Start()
    {
        ShowMenu();
    }
    
    public void ShowMenu()
    {
        HideLists();
        _menu.SetActive(true);
    }

    public void HideLists()
    {
        InputList[] _lists = _inputLists.GetInputLists();
        for (int i = 0; i < _lists.Length; i++)
        {
            _lists[i].GetPhysicalList().SetActive(false);
        }
    }
}