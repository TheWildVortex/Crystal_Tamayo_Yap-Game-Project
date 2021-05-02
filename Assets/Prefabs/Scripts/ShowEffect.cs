using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEffect : MonoBehaviour
{
    public GameObject Text;
    public Text EffectTxt;


    public void ShowText()
    {
        if (!Text.activeSelf) 
        {
            Text.SetActive(true); 
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) 
        {
            Text.SetActive(false); 
        }
    }
}