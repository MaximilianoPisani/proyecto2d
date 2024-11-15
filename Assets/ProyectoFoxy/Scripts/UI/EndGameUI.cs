using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameUI : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    void Start()
    {
        GameManager.Instance.onEndGame += TurnOnPanel;
    }

    private void TurnOnPanel()
    {
        _endPanel.SetActive(true);  
    }

    public void OnDestroy()
    {
        GameManager.Instance.onEndGame -= TurnOnPanel; 
    }
}