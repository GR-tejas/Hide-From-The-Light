using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Rigidbody2D rb;
    private Vector2 playerMoveInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void GetPlayerInput()
    {
        playerMoveInput.x = Input.GetAxisRaw("Horizontal");
        playerMoveInput.y = Input.GetAxisRaw("Vertical");
    }

    private void PlayerMovement()
    {
        rb.MovePosition(rb.position + playerMoveInput * moveSpeed * Time.deltaTime);
    }
}
