using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterToggle : MonoBehaviour
{
    public static bool WaterCheck = false;
    public int counter = 0;
    public Button Furite;
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
        }
        else
        {
            FuriteText.text = "Water";
            WaterCheck = false;
        }
    }
}