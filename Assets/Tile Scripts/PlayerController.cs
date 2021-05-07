using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Tilemap groundTiles;
    [SerializeField]
    private Tilemap collisionTiles;

    private Animator anim;
    private float x, y;
    private bool isWalking;
    public float moveSpeed;

    private PlayerMovement controls;

    private void Awake()
    {
        controls = new PlayerMovement();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
       controls.Main.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }

    private void Move(Vector2 direction)
    {

        if (CheckMove(direction))
            transform.position += (Vector3)direction;
    }

    private bool CheckMove(Vector2 direction)
    {
        Vector3Int gridPosition = groundTiles.WorldToCell(transform.position + (Vector3)direction);

        if (!groundTiles.HasTile(gridPosition) || collisionTiles.HasTile(gridPosition))
            return false;
        return true;
    }
}
