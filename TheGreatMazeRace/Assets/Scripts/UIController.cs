using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;

    public TMP_Text timerText;


    void Awake()
    {
        Instance = this;
    }

    public void UpdateTimer(float timer)
    {
        float min = Mathf.FloorToInt(timer/60f);
        float sec = Mathf.FloorToInt(timer % 60f);

        timerText.text = min + ":" + sec.ToString("00");
    }
}
