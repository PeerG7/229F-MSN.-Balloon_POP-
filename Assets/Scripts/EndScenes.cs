using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScenes : MonoBehaviour
{
    public static EndScenes Instance;
    public int score = 0;
    public TextMeshProUGUI scoreText; // เชื่อมกับ UI

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreUI(); // อัปเดตคะแนนตอนเริ่มเกม
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score Updated: " + score);
        UpdateScoreUI(); // อัปเดต UI
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("Score text is not assigned in GameManager!");
        }
    }
}
