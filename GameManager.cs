using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(this);
        }

    }

    void Update()
    {
        
    }
    public void GameOver()
    {
        Debug.Log("You Lose! Go home");
    }
}
