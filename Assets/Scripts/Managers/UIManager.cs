using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countText;

    GameManager gameManager;


    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void UpdateCount()
    {
        countText.text = "Count: " + gameManager.coinCount.ToString();
    }
}