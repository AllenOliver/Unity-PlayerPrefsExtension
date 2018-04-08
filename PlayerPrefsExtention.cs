using UnityEngine;

/// <summary>
/// Extends the Player Prefs system to allow the use of Bools
/// Allen Oliver 04/08/2018
/// </summary>
public class PlayerPrefsExtention : MonoBehaviour {

    /// <summary>
    /// Sets the bool with a key and a value
    /// converts to a playerprefs int 0 or 1
    /// </summary>
    /// <param name="name">Key to save value</param>
    /// <param name="value">true or false</param>
    public static void SetBool(string name, bool value)
    {
        PlayerPrefs.SetInt(name, value ? 1 : 0);
    }

    /// <summary>
    /// get bool  back WITHOUT default value
    /// </summary>
    /// <param name="name">Key it was saved as</param>
    /// <returns></returns>
    public static bool GetBool(string name)
    {
        return PlayerPrefs.GetInt(name) == 1 ? true : false;
    }

    /// <summary>
    /// Get bool back WITH default value
    /// </summary>
    /// <param name="name">Key it was saved as</param>
    /// <param name="defaultValue">the default true or false if null</param>
    /// <returns>the default value</returns>
    public static bool GetBool(string name, bool defaultValue)
    {
        if (PlayerPrefs.HasKey(name))
        {
            return GetBool(name);
        }

        return defaultValue;
    }
    
}
