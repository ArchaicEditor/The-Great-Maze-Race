using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PotionManager2 : MonoBehaviour
{
    public TMP_Text potionText;
    private int number = 0;

    // This function will be called to increase the number
    public void AddPotions(int amount)
    {
        number += amount;
        UpdateCountDisplay();
    }

    // This function updates the UI text to display the current score
    private void UpdateCountDisplay()
    {
        potionText.text = "x" + number.ToString();
    }
}
