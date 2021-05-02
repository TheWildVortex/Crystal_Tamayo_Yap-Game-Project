using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitDisplay : MonoBehaviour
{
    public Text textName;
    public Image sprite;

    public Unit unitType;


    // Start is called before the first frame update
    void Start()
    {
        if (unitType != null) Prime (unitType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Prime(Unit unitType)
    {
        this.unitType = unitType;
        if (textName != null)
            textName.text = unitType.unitName;
        if(sprite != null)
            sprite.sprite = unitType.sprite;
    }
}
