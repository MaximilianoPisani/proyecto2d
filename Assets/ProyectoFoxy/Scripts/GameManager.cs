using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    [SerializeField] private int _endScore;

    public OnEndGame onEndGame;
    public delegate void OnEndGame();

    private int _score;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void IncreaseScore(int amount)
    {
        _score += amount;
        Debug.Log($"Current Score: {_score}");

        if (_score >= _endScore)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        Debug.Log($"Game Finished");
        onEndGame?.Invoke();
    }
}