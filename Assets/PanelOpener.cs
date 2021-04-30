using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public Button AttackB;
    public Button CastB;
    public Button FuriteB;
    public Button RunB;

    public void PanelToggle()
    {
        if (!Panel.activeSelf)
        {
            Panel.SetActive(true);
            AttackB.interactable = false;
            CastB.interactable = false;
            FuriteB.interactable = false;
            RunB.interactable = false;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Panel.SetActive(false);
            AttackB.interactable = true;
            CastB.interactable = true;
            FuriteB.interactable = true;
            RunB.interactable = true;
        }
    }
}
