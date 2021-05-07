using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggertest : MonoBehaviour
{
    public Text displayText;
    public string Name;
    string SelectedSpell = "";

    public Button AttackB, CastB, FuriteB, RunB;
    public GameObject UnitPanel, UnitCastPanel, CastPanel, FuritePanel;

    void Start()
    {
        displayText.text = "";
        SelectedSpell = "";
    }

    public void DisplayText()
    {
        SelectedSpell = PlayerPrefs.GetString("SelectedSpell");
        displayText.text = "You hit " + Name + " with your " + SelectedSpell + " attack!";
        SelectedSpell = "";
        PlayerPrefs.SetString("SelectedSpell", "");

        UnitPanel.SetActive(false);
        UnitCastPanel.SetActive(false);
        CastPanel.SetActive(false);
        FuritePanel.SetActive(false);
        AttackB.interactable = true; //Enable Attack Button
        CastB.interactable = true; //Enable Cast Button
        FuriteB.interactable = true; //Enable Furite Button
        RunB.interactable = true; //Enable Run Button
    }
}
