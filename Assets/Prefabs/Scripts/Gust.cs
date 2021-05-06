using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gust : MonoBehaviour
{
    public string SpellName;

    public void OnClick()
    {
        PlayerPrefs.SetString("SelectedSpell", "Gust");
    }
}
