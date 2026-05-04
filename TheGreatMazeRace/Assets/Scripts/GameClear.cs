using UnityEngine;

public class GameClear : MonoBehaviour
{
    public GameObject player;
    public GameObject clearScreen;
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            clearScreen.SetActive(true);
            player.SetActive(false);
            gameManager.gameActive = false;
        }
    }
}
