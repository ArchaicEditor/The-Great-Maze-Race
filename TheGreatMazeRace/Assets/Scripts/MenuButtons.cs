using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuButtons : MonoBehaviour
{
   
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        if (File.Exists(SaveSystem.Instance.savePath))
        {
            File.Delete(SaveSystem.Instance.savePath);
            Debug.Log("Save file deleted at: " + SaveSystem.Instance.savePath);
            SceneManager.LoadScene("Game");
        } else
        {
            SceneManager.LoadScene("Game");
        }
        
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

}
