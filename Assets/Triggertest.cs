using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggertest : MonoBehaviour
{
    public Text displayText;
    public string Name;

    void Start()
    {
        displayText.text = "";
    }

    public void DisplayText()
    {
        displayText.text = "You hit " + Name + " with your spell";
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            displayText.text = "";
        }
    }
}
