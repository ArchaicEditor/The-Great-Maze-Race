using UnityEngine;

public class Lever : MonoBehaviour
{

    public GameObject lever;
    public GameObject wall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wall.SetActive(false);
            lever.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
