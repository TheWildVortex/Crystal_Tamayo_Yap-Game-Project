using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthToggle : MonoBehaviour
{
    public static bool EarthCheck = false;
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
            FuriteText.text = "<Earth>";
            EarthCheck = true;
        }
        else
        {
            FuriteText.text = "Earth";
            EarthCheck = false;
        }
    }
}
