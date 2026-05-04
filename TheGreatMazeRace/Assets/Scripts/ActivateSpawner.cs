using UnityEngine;

public class ActivateSpawner : MonoBehaviour
{
    public GameObject spawner;
    public GameObject firstEnemy;

    private void OnTriggerEnter2D(Collider2D other)
    {
        spawner.SetActive(true);
        firstEnemy.SetActive(true);
    }
}
