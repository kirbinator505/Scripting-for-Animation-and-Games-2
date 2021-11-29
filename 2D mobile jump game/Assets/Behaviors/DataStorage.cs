using UnityEngine;

[CreateAssetMenu(fileName = "DataStorage", menuName = "Utilities/Data Storage Object")]
public class DataStorage : ScriptableObject
{
    public ScriptableObject data;

    public void SetData(ScriptableObject obj)
    {
        if (obj == null) return;
        PlayerPrefs.SetString(obj.name, JsonUtility.ToJson(obj));
    }

    public void SetData()
    {
        if (data == null) return;
        PlayerPrefs.SetString(data.name, JsonUtility.ToJson(data));
    }

    public void GetData()
    {
        if (data == null) return;
        if(!string.IsNullOrEmpty(PlayerPrefs.GetString(data.name)))
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(data.name), data);
    }
}
