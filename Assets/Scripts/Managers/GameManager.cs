using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public int coinCount;

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

    public void UpdateCount()
    {
        coinCount++;
    }
}
