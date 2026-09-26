using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }

        else if (manager != null)
        {
            Destroy(gameObject);
        }
    }
}
