using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleManager : MonoBehaviour
{          
    public Sprite[] images;
    public Image currentImage;
    public Toggle[] toggles;

    public void SetSlide(int index)
    {
        if (index >= 0 && index < images.Length)
        {
            currentImage.sprite = images[index];
        }
    }
}
