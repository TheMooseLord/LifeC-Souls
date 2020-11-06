using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenChanger : MonoBehaviour
{
    public MainScript game;

    public void GoToSettings1()
    {
        game.Settings1.gameObject.SetActive(true);
    }

    public void GoBackFromSettings1()
    {
        game.Settings1.gameObject.SetActive(false);
    }
    public void GoToSettings2()
    {
        game.Settings2.gameObject.SetActive(true);
    }

    public void GoBackFromSettings2()
    {
        game.Settings2.gameObject.SetActive(false);
    }

    public void GoToMainScreen()
    {
        game.MainScreen.gameObject.SetActive(true);
    }
    public void GoToDLScreen()
    {
        game.DLScreen.gameObject.SetActive(true);
    }
    public void GoBackFromDLScreen()
    {
        game.DLScreen.gameObject.SetActive(false);
    }
    public void GoToBrainsScreen()
    {
        game.brainSwitchText.text = "Locked....\n1e15 Life";
        if (game.data.life <= 1e15) return;
        {
            game.brainSwitchText.text = "BrainScreen";
            game.BrainScreen.gameObject.SetActive(true);
        }
    }
    public void GoBackFromBrainsScreen()
    {
        game.BrainScreen.gameObject.SetActive(false);
    }
    public void FullResetToMain()
    {
        FullReset();
        game.BrainScreen.gameObject.SetActive(false);
        game.DLScreen.gameObject.SetActive(false);
        game.Settings1.gameObject.SetActive(false);
        game.Settings2.gameObject.SetActive(false);
    }

    public void FullReset()
    {
        game.data.FullReset();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
