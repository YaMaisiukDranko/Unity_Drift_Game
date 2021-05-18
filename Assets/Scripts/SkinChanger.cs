using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    public GameObject[] Skins;
    private int currentSkin = 0;

    public void NextSkin()
    {
        if (Skins.Length == 0)
            return;
        Skins[currentSkin].SetActive(false);
        currentSkin++;
        if (currentSkin == Skins.Length)
            currentSkin = 0;

        Skins[currentSkin].SetActive(true);
    }

    public void PrevSkin()
    {
        if (Skins.Length == 0)
            return;
        Skins[currentSkin].SetActive(false);
        currentSkin--;
        if (currentSkin == -1)
            currentSkin = Skins.Length - 1;

        Skins[currentSkin].SetActive(true);
    }
}
