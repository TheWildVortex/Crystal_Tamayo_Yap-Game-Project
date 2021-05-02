using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyListDisplay : MonoBehaviour
{
    public Unit unitName;
    
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
        if (unitName != null)
            unitName.unitName = unitType.unitName;

    }
}
