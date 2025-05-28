using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private float timeInterval = 2.0f;

    private int score = 0;

    private float timer = 0f;

    [SerializeField]
    private bool isTimerStarted;

    void Start()
    {
        scoreText.text = $"{score}";
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeInterval && isTimerStarted == true)
        {
            score++;
            scoreText.text = $"{score}";
            timer = 0f;
        }
    }
}
