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

}