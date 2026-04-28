using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class SpeedPotionPickup : MonoBehaviour
{
    public int potionNumber = 1;

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PotionManager2 scoreManager = FindObjectOfType<PotionManager2>();
            if (scoreManager != null)
            {
                scoreManager.AddPotions(potionNumber);
            }
            DataManager.Instance.RecordItemCollected("Speed Potion");
            Destroy(gameObject);
        }
    }
}
