using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpenFunction : MonoBehaviour
{
    public GameObject Panel; //Panel that needs to be opened
    public Button AttackB,CastB,FuriteB,RunB; //Create variables for buttons
    

    public void PanelToggle()
    {
        if (!Panel.activeSelf) //Check if panel is not active
        {
            Panel.SetActive(true); //Set panel to active
        }
    }

    private void Update() //Checks every frame
    {
        if (Input.GetKey(KeyCode.Escape)) //Check if Escape key is pressed
        {
            Panel.SetActive(false); //Set panel to not active
        }
    }
}