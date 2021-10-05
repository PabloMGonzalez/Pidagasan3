using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class OptionsMenu : MonoBehaviour
{
public void SetFullscreen (bool isFullScreen)
{
    Screen.fullScreen = isFullScreen;
}

List<int> widths = new List<int>() {568, 960, 1280, 1920};
List<int> eights = new List<int>() {320, 540, 800, 1080};

public void SetScreenSize (int index)
{
    bool fullscreen = Screen.fullScreen;
    int width = widths[index];
    int eight = eights[index];
    Screen.SetResolution(width, eight, fullscreen);
}

}
