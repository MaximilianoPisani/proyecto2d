using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameUI : MonoBehaviour
{
    [SerializeField] private GameObject _endPanel;
    [SerializeField] private GameObject _lifeBar; // Referencia a la barra de vida

    void Start()
    {
        GameManager.Instance.onEndGame += TurnOnPanel;
    }

    private void TurnOnPanel()
    {
        _endPanel.SetActive(true);
        _lifeBar.SetActive(false); // Desactiva la barra de vida
    }

    public void OnDestroy()
    {
        GameManager.Instance.onEndGame -= TurnOnPanel;
    }
}