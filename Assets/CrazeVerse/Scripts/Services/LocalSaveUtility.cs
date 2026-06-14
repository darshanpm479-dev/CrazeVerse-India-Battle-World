// CrazeVerse Step 7 local save utility. Uses PlayerPrefs and JsonUtility only.
using UnityEngine;

namespace CrazeVerse.Services
{
    public static class LocalSaveUtility
    {
        public static bool HasSave()
        {
            return PlayerPrefs.HasKey(LocalSaveKeys.MainSaveKey);
        }

        public static LocalSaveData Load()
        {
            if (!HasSave())
            {
                return LocalSaveData.CreateDefault();
            }

            string json = PlayerPrefs.GetString(LocalSaveKeys.MainSaveKey, string.Empty);
            if (string.IsNullOrWhiteSpace(json))
            {
                return LocalSaveData.CreateDefault();
            }

            LocalSaveData data = JsonUtility.FromJson<LocalSaveData>(json);
            return data ?? LocalSaveData.CreateDefault();
        }

        public static void Save(LocalSaveData data)
        {
            LocalSaveData safeData = data ?? LocalSaveData.CreateDefault();
            string json = JsonUtility.ToJson(safeData);
            PlayerPrefs.SetString(LocalSaveKeys.MainSaveKey, json);
            PlayerPrefs.Save();
        }

        public static void DeleteSave()
        {
            PlayerPrefs.DeleteKey(LocalSaveKeys.MainSaveKey);
            PlayerPrefs.DeleteKey(LocalSaveKeys.ProfileKey);
            PlayerPrefs.DeleteKey(LocalSaveKeys.FirstLaunchKey);
            PlayerPrefs.Save();
        }
    }
}
