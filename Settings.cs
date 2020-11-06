using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public MainScript game;
    public AudioMixer audioMixer;


    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }














    public int[,] screenResolutionArray = {
        {1920, 1080},
        {1600,  900},
        {1536,  864},
        {1440,  900},
        {1366,  768},
        {1280, 1024},
        {1280,  800},
        {1280,  720},
        {1024,  768}
    };



    public void SwitchResolutionType()
    {
        if (game.data.screenResolutionIndex >= 8) game.data.screenResolutionIndex = -1;
        game.data.screenResolutionIndex++;
        int i = game.data.screenResolutionIndex;
        Screen.SetResolution(screenResolutionArray[i, 0], screenResolutionArray[i, 1], true);
    }
}
