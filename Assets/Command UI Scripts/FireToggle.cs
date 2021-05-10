using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireToggle : MonoBehaviour
{
    public static bool FireCheck = false;
    public int counter = 0;
    public Button Furite, FireB, WaterB, EarthB, WindB;
    public Text FuriteText;

    void Update()
    {
        FuriteText.text = Furite.GetComponentInChildren<Text>().text;
    }

    public void FuriteToggler()
    {
        counter++;
        if (counter % 2 == 1)
        {
            FuriteText.text = "<Fire>";
            FireCheck = true;
            WaterB.interactable = false;
            EarthB.interactable = false;
            WindB.interactable = false;
        }
        else
        {
            FuriteText.text = "Fire";
            FireCheck = false;
            WindB.interactable = true;
            WaterB.interactable = true;
            EarthB.interactable = true;
        }
    }
}
