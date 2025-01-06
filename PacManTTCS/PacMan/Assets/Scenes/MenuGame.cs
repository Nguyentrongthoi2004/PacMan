using UnityEngine;
using UnityEngine.SceneManagement; // Thư viện quản lý scene
using UnityEngine.UI; // Thư viện quản lý UI

public class MenuGame : MonoBehaviour
{
    [SerializeField] private Text scoreText; // Text để hiển thị điểm (gắn từ Unity Editor)

    // Bắt đầu trò chơi (chuyển đến Scene game chính)
    public void StartGame()
    {
        Debug.Log("Starting Game...");
        SceneManager.LoadScene(1); // Tải Scene có index 1 (GameScene)
        Time.timeScale = 0;
    }

    // Quay lại menu chính (chuyển đến Scene menu chính)
    public void BackToMenu()
    {
        Debug.Log("Returning to Main Menu...");
        SceneManager.LoadScene(0); // Tải Scene có index 0 (MainMenu)
    }

    // Hiển thị điểm số hiện tại
    public void ShowScore()
    {
        if (scoreText != null)
        {
            int currentScore = GameManager.Instance.score; // Lấy điểm từ GameManager
            scoreText.text = "Score: " + currentScore.ToString(); // Hiển thị điểm
            Debug.Log("Displaying Score: " + currentScore);
        }
        else
        {
            Debug.LogWarning("Score Text UI is not assigned in the Inspector!");
        }
    }

    // Thoát trò chơi
    public void ExitGame()
    {
        Debug.Log("Exit button clicked!"); // Kiểm tra nút hoạt động
        Application.Quit();

        // Debug trong Unity Editor
#if UNITY_EDITOR
        Debug.Log("Game is quitting in Editor mode!");
#endif
    }
}
