using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    private Vector2 movement;
    private SaveSystem saveSystem;

    [System.Obsolete]
    public void Start()
    {
        PlayerData data = SaveSystem.Instance.LoadPlayer();
        

        if (data != null)
        {
            transform.position = new Vector2(data.posX, data.posY);
        }
    }
    void Update()
    {
        // Get input from keyboard (WASD / Arrow Keys)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalize diagonal movement so it's not faster
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void SaveAtCheckpoint()
    {
        SaveSystem.Instance.SavePlayer(transform.position);
    }
}
