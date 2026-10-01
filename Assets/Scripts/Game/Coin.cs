using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour, IInteractable
{
    GameManager gameManager;
    UIManager uiManager;

    Coin coin;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        uiManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    public void Interact()
    {
        Debug.Log("Debug Log");
        gameManager.UpdateCount();
        uiManager.UpdateCount();
        this.gameObject.SetActive(false);
        waitToRespawn();
    }

    IEnumerator waitToRespawn()
    {
        yield return new WaitForSeconds(3f);
        this.gameObject.SetActive(true);

    }
}

