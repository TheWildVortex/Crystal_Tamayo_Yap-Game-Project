using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAiming : MonoBehaviour
{
    public float turnSpeed = 15;
    Camera mainCamera;
    RaycastWeapon weapon;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        weapon = GetComponentInChildren<RaycastWeapon>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime);
    }

    private void LateUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            weapon.Fire();
        }
    }
}
