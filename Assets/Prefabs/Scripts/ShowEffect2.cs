using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEffect2 : MonoBehaviour
{
    public GameObject EffectTxtPrefab;
    // Start is called before the first frame update
    public void CastSpell()
    {
        Instantiate(EffectTxtPrefab);
    }

}
