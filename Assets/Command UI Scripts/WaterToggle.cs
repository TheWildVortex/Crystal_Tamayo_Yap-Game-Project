using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterToggle : MonoBehaviour
{
    public static bool WaterCheck = false;
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
            FuriteText.text = "<Water>";
            WaterCheck = true;
            FireB.interactable = false;
            EarthB.interactable = false;
            WindB.interactable = false;
        }
        else
        {
            FuriteText.text = "Water";
            WaterCheck = false;
            FireB.interactable = true;
            WindB.interactable = true;
            EarthB.interactable = true;
        }
    }
}
