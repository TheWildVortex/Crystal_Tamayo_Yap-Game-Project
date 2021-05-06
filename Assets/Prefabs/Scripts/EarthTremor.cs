using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTremor : MonoBehaviour
{
    public string SpellName;

    public void OnClick()
    {
        PlayerPrefs.SetString("SelectedSpell", "Earth Tremor");
    }
}
