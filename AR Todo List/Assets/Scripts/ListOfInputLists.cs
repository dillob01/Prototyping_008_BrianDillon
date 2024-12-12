using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfInputLists : MonoBehaviour
{
    [SerializeField] private InputList[] _inputLists;

    //Contains a list of input lists
    public InputList[] GetInputLists()
    {
        return _inputLists;
    }
}