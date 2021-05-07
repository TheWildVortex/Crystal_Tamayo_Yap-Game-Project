using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggertest : MonoBehaviour
{
    public Text displayText;
    public string Name;
    string SelectedSpell = "";

    void Start()
    {
        displayText.text = "";
    }

    public void DisplayText()
    {
        SelectedSpell = PlayerPrefs.GetString("SelectedSpell");
        displayText.text = "You hit " + Name + " with your " + SelectedSpell + " attack!";
        SelectedSpell = "";
        PlayerPrefs.SetString("SelectedSpell", "");
    }
}
