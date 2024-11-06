using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PianoAudioScript : MonoBehaviour
{
    [SerializeField] private AudioClip _pianoKey;
    [SerializeField] private AudioSource _source;
    [SerializeField] private float _pitch;

    public void PlayKey()
    {
        _source.pitch = _pitch;
        _source.PlayOneShot(_pianoKey);
    }
}
