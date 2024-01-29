using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicControl : MonoBehaviour
{
    [SerializeField] public AudioMixer myAudioMixer;

    public void SetVolume(float sliderValue)
    {
        myAudioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }


}
