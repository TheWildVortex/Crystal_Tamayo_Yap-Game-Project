using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementCheck : MonoBehaviour
{
    public Button Charm, FireSpell, WaterSpell, EarthSpell, WindSpell;

    // Update is called once per frame
    void Update()
    {
        FireSpell.gameObject.SetActive(FireToggle.FireCheck);
        WaterSpell.gameObject.SetActive(WaterToggle.WaterCheck);
        EarthSpell.gameObject.SetActive(EarthToggle.EarthCheck);
        WindSpell.gameObject.SetActive(WindToggle.WindCheck);
    }
}
