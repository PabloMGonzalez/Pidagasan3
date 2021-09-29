using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
public AudioMixer audioMixer;
public void SetFullscreen (bool isFullScreen)
{
    Screen.fullScreen = isFullScreen;
}
public void SetVolume (float volume)
{
    audioMixer.SetFloat("Volumen",  volume);
}
public void PlayGame ()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

public void QuitGame ()
{
    Debug.Log("QUIT");
    Application.Quit();

}

}
