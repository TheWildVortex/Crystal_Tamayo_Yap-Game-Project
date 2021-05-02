using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyListDisplay : MonoBehaviour
{
    public Enemy Enemy_Name;
    
    public EnemyType Type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Prime(EnemyType Type)
    {
        this.Type = Type;
        if (textName != null)
            textName.text = Type.displayName;

    }
}
