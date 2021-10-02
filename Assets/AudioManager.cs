using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
public AudioMixer audioMixer;
public void SetVolume (float volume)
{
    Debug.Log(volume);
    audioMixer.SetFloat("Volumen",  volume);
}

}
