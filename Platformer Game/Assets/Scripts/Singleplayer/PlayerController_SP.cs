using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_SP : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public CharacterController controller;
    public GameManager_SP managerGame_SP;
    private Vector3 moveDirection;
    public float gravityScale;

    void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    void Update()
    {
        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical")*moveSpeed) + (transform.right * Input.GetAxis("Horizontal")*moveSpeed);
        //moveDirection = moveDirection.normalized * moveSpeed;
        moveDirection.y = yStore;

        if (controller.isGrounded)
        {
            moveDirection.y = 0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpForce;
            }

        }
            moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
            controller.Move(moveDirection * Time.deltaTime);
        
        //Game Stopped
        managerGame_SP.managerUI_SP.GameStopped();
    }   
}
