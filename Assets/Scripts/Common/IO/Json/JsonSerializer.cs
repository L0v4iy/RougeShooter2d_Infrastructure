using System;
using System.IO;
using UnityEngine;

namespace IO.Save
{
    public static class JsonSerializer
    {
        private const string FileName = "Save.json";
        private static readonly string FilePath;

        public static SaveData Data { get; private set; }

        static JsonSerializer()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            FilePath = Path.Combine(Application.persistentDataPath, FileName);
#endif
#if UNITY_64 || UNITY_EDITOR
            FilePath = Path.Combine(Application.dataPath, FileName);
#endif
            Data = LoadData();
        }

        private static SaveData LoadData()
        {
            if (File.Exists(FilePath))
                return JsonUtility.FromJson<SaveData>(File.ReadAllText(FilePath));

            SaveData(GetDefault());
            return Data;
        }

        public static void SaveData(SaveData data)
        {
            Data = data;
            File.WriteAllText(FilePath, JsonUtility.ToJson(data));
        }

        private static SaveData GetDefault()
        {
            return new SaveData()
            {
            };
        }
    }
}

[Serializable]
public struct SaveData
{
}