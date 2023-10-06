using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerData
{
    public int coins;
}



public class SvaingData : MonoBehaviour
{
    string SaveFilePath;
    PlayerData playerData;
    void Start()
    {
        playerData = new PlayerData();
        playerData.coins = 0;
        SaveFilePath = Application.persistentDataPath + "/playerdata.Json";
        
    }

    public void SaveCoins()
    {
        string saveplayerData = JsonUtility.ToJson(playerData);
        File.WriteAllText(SaveFilePath, saveplayerData);    
    }
    
    public void LoadCoins()
    {
        if (File.Exists(SaveFilePath))
        {
            string LoadplayerData = File.ReadAllText(SaveFilePath);
            playerData = JsonUtility.FromJson<PlayerData>(LoadplayerData);
        }
    }
}
