using UnityEngine;

public class PressurePlates : MonoBehaviour
{
    public GameObject wall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wall.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
