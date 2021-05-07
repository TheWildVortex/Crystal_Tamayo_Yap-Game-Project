using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel; //Panel that needs to be opened
    public Button AttackB,CastB,FuriteB,RunB; //Create variables for buttons
    

    public void PanelToggle()
    {
        if (!Panel.activeSelf) //Check if panel is not active
        {
            Panel.SetActive(true); //Set panel to active
            AttackB.interactable = false; //Disable Attack Button
            CastB.interactable = false; //Disable Cast Button
            FuriteB.interactable = false; //Disable Furite Button
            RunB.interactable = false; //Disable Run Button
        }
    }

    private void Update() //Checks every frame
    {
        if (Input.GetMouseButtonDown(1)) //Check if Right Click is pressed
        {
            Panel.SetActive(false); //Set panel to not active
            AttackB.interactable = true; //Enable Attack Button
            CastB.interactable = true; //Enable Cast Button
            FuriteB.interactable = true; //Enable Furite Button
            RunB.interactable = true; //Enable Run Button
        }
    }
}
