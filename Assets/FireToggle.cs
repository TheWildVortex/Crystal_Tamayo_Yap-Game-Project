using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireToggle : MonoBehaviour
{
    public static bool FireCheck;
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
            FuriteText.text = "<Fire>";
            FireCheck = true;
        }
        else
        {
            FuriteText.text = "Fire";
            FireCheck = false;
        }
    }
}
