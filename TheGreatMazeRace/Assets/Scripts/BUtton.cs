using UnityEngine;

public class BUtton : MonoBehaviour
{
    public GameObject button;
    public GameObject visibleButton;
    public GameObject wall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wall.SetActive(false);
            button.SetActive(true);
            visibleButton.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
