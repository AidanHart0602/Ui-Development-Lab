using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text _healthText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _slider.value < 100)
        {
            _slider.value += 20;
        }

        if (Input.GetKeyDown(KeyCode.E) && _slider.value > 0)
        {
            _slider.value -= 20;
        }

        _healthText.text = "Health: " + _slider.value + "%";
    }
}
