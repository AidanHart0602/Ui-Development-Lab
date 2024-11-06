using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DifficultyDropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _difficulty;
    [SerializeField] private TMP_Text _text;
    public void DifficultyChange()
    {
        if(_difficulty.value == 0)
        {
            _text.text = "Set to easy";
        }

        if (_difficulty.value == 1)
        {
            _text.text = "Set to medium";
        }

        if (_difficulty.value == 2)
        {
            _text.text = "Set to hard";
        }
    }
}
