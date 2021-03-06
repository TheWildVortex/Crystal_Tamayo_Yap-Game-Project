using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindToggle : MonoBehaviour
{
    public static bool WindCheck = false;
    public int counter = 0;
    public Button Furite,FireB, WaterB, EarthB, WindB;
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
            FuriteText.text = "<Wind>";
            WindCheck = true;
            FireB.interactable = false;
            WaterB.interactable = false;
            EarthB.interactable = false;
        }
        else
        {
            FuriteText.text = "Wind";
            WindCheck = false;
            FireB.interactable = true;
            WaterB.interactable = true;
            EarthB.interactable = true;
        }
    }
}
