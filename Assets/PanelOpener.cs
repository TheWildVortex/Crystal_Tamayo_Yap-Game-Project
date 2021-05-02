using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel; //Panel that needs to be opened
    public Button Ducky; //Ducky Enemy
    public Button Goblin; //Cast Button
    public Button Abberation; //Furite Button
    public Button Slime; //Run button
    

    public void PanelToggle()
    {
        if (!Panel.activeSelf) //Check if panel is not active
        {
            Panel.SetActive(true); //Set panel to active
            Ducky.interactable = false; //Disable Attack Button
            Goblin.interactable = false; //Disable Cast Button
            Abberation.interactable = false; //Disable Furite Button
            Slime.interactable = false; //Disable Run Button
        }
    }

    private void Update() //Checks every frame
    {
        if (Input.GetKey(KeyCode.Escape)) //Check if Escape key is pressed
        {
            Panel.SetActive(false); //Set panel to not active
            AttackB.interactable = true; //Enable Attack Button
            Goblin.interactable = true; //Enable Cast Button
            Abberation.interactable = true; //Enable Furite Button
            Slime.interactable = true; //Enable Run Button
        }
    }
}
