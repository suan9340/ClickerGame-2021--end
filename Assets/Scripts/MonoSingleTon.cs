using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleTon<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool suhttingDown = false;
    private static object locker = new object();
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            if (suhttingDown)
            {
                Debug.LogWarning("[instance] Instance" + typeof(T) + "is already destroyed. Returning null.");
                return null;
            }

            lock (locker)
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();

                    if (_instance == null)
                    {
                        _instance = new GameObject(typeof(T).ToString()).AddComponent<T>();
                        DontDestroyOnLoad(_instance);
                    }
                }
                return _instance;
            }

        }
    }

    private void OnDestroy()
    {
        suhttingDown = true;
    }

    private void OnApplicationQuit()
    {
        suhttingDown = true;
    }
}
