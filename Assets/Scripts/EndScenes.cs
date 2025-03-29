using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScenes : MonoBehaviour
{
    public static EndScenes Instance;
    public int score = 0;
    public TextMeshProUGUI scoreText; // เชื่อมกับ UI

    public int targetScore = 100;
    public string End = "End";
    public string End2 = "End2";

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
        check();
        check2();
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

    void check()
    {
        if (score >= 100 )
        {
            Debug.Log("Target Score Reached! Changing Scene...");
            UnityEngine.SceneManagement.SceneManager.LoadScene(End);
        }
    }
    void check2()
    {
        if (score <= -40)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(End2);
        }
    }
}
