using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharmPerson : MonoBehaviour
{
    public string SpellName;

    public void OnClick()
    {
        PlayerPrefs.SetString("SelectedSpell", "Charm Person");
    }
}
