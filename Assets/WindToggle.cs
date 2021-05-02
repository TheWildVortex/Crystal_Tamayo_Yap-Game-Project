using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindToggle : MonoBehaviour
{
    public static bool WindCheck;
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
            FuriteText.text = "<Wind>";
            WindCheck = true;
        }
        else
        {
            FuriteText.text = "Wind";
            WindCheck = false;
        }
    }
}
