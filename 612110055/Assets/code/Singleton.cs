using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T:MonoBehaviour
{
    private static bool m_shuttingDown = false;
    private static object m_Lock = new object();
    private static T m_Instancel;

    // Start is called before the first frame update
   public static T Instance {
        get {
            if (m_shuttingDown)
            { Debug.LogWarning("[Singleton] Instance" + 
                typeof(T) + "already destoryed.Returning null.");
                return null;
            }
            lock (m_Lock) {
                if (m_Instancel == null)
                {
                    m_Instancel = (T)FindObjectOfType(typeof(T));
                    if (m_Instancel == null)
                    {
                        var singletonObject = new GameObject();
                        m_Instancel = singletonObject.AddComponent<T>();
                        singletonObject.name = typeof(T).ToString() + "(Sigleton)";

                        DontDestroyOnLoad(singletonObject);
                    }
                    else DontDestroyOnLoad(m_Instancel);
                }
                return m_Instancel;
            }
        }
    }

    private void OnApplicationQuit()
    {
        m_shuttingDown = true;
    }
    private void OnDestroy()
    {
       // m_shuttingDown = true;
    }
    private void Awake()
    {
        var t = Singleton<T>.Instance;
            if(Instance!=null)
        {
            if (this != Instance)
                Destroy(this.gameObject);
        }
    }
}
