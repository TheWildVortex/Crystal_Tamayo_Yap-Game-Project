using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthToggle : MonoBehaviour
{
    public static bool EarthCheck = false;
    public int counter = 0;
    public Button Furite,FireB,WaterB,EarthB,WindB;
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
            FuriteText.text = "<Earth>";
            EarthCheck = true;
            FireB.interactable = false;
            WaterB.interactable = false;
            WindB.interactable = false;
        }
        else
        {
            FuriteText.text = "Earth";
            EarthCheck = false;
            FireB.interactable = true;
            WaterB.interactable = true;
            WindB.interactable = true;
        }
    }
}
