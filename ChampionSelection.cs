using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChampionSelection : MonoBehaviour
{
    public ChampionManager championManager; 
    public Transform parentPos;
    public GameObject championButtonPrefab;
    public ChampionView championView;

    private void Start()
    {
        foreach(Champion c in championManager.champions)
        {
            GameObject buttonPrefab = Instantiate(championButtonPrefab,parentPos);
            ChampionButton championButton = buttonPrefab.GetComponent<ChampionButton>();
            championButton.SetData(c);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => championView.ShowData(c));
        }
    }
}
