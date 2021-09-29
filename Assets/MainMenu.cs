using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Dropdown ResolutionDropdown;
 Resolution[] resolutions;
        private void Start()
    {
        int CurrentResolutionIndex = 0;
        resolutions = Screen.resolutions;

        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string Option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(Option);

            if(resolutions[i].width == Screen.width &&
                resolutions[i].height == Screen.height)
            {
                CurrentResolutionIndex = i;
            }
        }

        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = CurrentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int ResolutionIndex)
    {
        Resolution resolution = resolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

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
