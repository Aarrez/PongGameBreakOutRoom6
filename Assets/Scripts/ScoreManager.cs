using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private TextMeshProUGUI[] scoreText;
    private ResetOnHit[] _resetOnHit;

    private int _playerLeftScore, _playerRightScore = 0;
    
    private void Awake()
    {
        scoreText = FindObjectsOfType<TextMeshProUGUI>();
        _resetOnHit = FindObjectsOfType<ResetOnHit>();
    }

    private void Start()
    {
        _resetOnHit[0].AddScoreRight += AddPointRight;
        _resetOnHit[1].AddScoreLeft += AddPointLeft;
        
        scoreText[0].text = $"0" + _playerLeftScore;
        scoreText[1].text = $"0" + _playerRightScore;
    }

    private void AddPointLeft(int i)
    {
        _playerLeftScore += i;
        
        scoreText[0].text = $"0" + _playerLeftScore;
    }

    private void AddPointRight(int i)
    {
        _playerRightScore += i;

        scoreText[1].text = $"0" + _playerRightScore;
    }
}
