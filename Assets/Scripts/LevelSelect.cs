using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons; 
    private int highestCompletedLevel = 1; 

    private void Start()
    {
        
        highestCompletedLevel = PlayerPrefs.GetInt("HighestCompletedLevel", 1);

        
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > highestCompletedLevel)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    
    public void FlagTriggered()
    {
        
        highestCompletedLevel++;
        PlayerPrefs.SetInt("HighestCompletedLevel", highestCompletedLevel);
        PlayerPrefs.Save();
        
        levelButtons[highestCompletedLevel - 1].interactable = true;
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
