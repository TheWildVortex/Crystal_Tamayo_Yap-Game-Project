using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private Tilemap groundTiles;
    [SerializeField]
    private Tilemap collisionTiles;

    private Animator anim;
    private float x, y;
    private bool isWalking;
    public float moveSpeed;
    private Vector2 dir;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        dir = new Vector2(x, y);

        if (x!=0||y!=0)
        {
            if(!isWalking)
            {
                isWalking = true;
                anim.SetBool("isWalking", isWalking);
            }
            Move(dir);
        }
        else
        {
            if(isWalking)
            {
                isWalking = false;
                anim.SetBool("isWalking", isWalking);
            }
        }
    }

    private void Move(Vector2 direction)
    {
        if (CheckMove(direction))
            anim.SetFloat("X", x);
            anim.SetFloat("Y", y);

            transform.Translate(x * Time.deltaTime * moveSpeed, y * Time.deltaTime * moveSpeed, 0);
    }

    private bool CheckMove(Vector2 direction)
    {
        Vector3Int gridPosition = groundTiles.WorldToCell(transform.position + (Vector3)direction);

        if (!groundTiles.HasTile(gridPosition) || collisionTiles.HasTile(gridPosition))
            return false;
        return true;
    }
}
