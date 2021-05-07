using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYER_TURN, ENEMY_TURN, WON, LOSS }
public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;


    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {

    }

}
