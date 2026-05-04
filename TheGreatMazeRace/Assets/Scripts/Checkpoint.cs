using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = other.GetComponent<PlayerMovement>();
        if (player != null)
        {
            player.SaveAtCheckpoint();
            Debug.Log("Checkpoint reached!");
            gameObject.SetActive(false);
        }
    }
}
