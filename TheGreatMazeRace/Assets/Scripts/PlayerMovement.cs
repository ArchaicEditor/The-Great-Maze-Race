using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    private Vector2 movement;
    private SaveSystem saveSystem;

    public PotionManager2 speedPotionManager;
    public PlayerStats playerStats;




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

        if (speedPotionManager.number > 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                speedPotionManager.RemovePotions(1);
                playerStats.BoostSpeed(3);
                moveSpeed += 3;
            }
        }
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerStats.TakeDamage(10);
            
        }
    }

    public void SaveAtCheckpoint()
    {
        SaveSystem.Instance.SavePlayer(transform.position);
    }
}
