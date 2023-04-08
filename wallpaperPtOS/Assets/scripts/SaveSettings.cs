using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSettings : MonoBehaviour
{
    [SerializeField] private BackgroundSetting _BackgroundSetting = new BackgroundSetting();

    public void SaveIntoJson()
    {
        string potion = JsonUtility.ToJson(_BackgroundSetting);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PotionData.json", potion);
    }
}

[System.Serializable]
public class BackgroundSetting
{
    public Sprite numberbg;
    
}