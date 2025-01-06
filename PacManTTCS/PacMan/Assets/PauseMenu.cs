using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 0;
    }
    public void Easy()
    {
        // Thiết lập độ khó Easy
        GameManager.Instance.SetDifficulty(5f, 5f, 10f);
        RestartGame();
    }

    public void Normal()
    {
        // Thiết lập độ khó Normal
        GameManager.Instance.SetDifficulty(5f, 10f, 7f);
        RestartGame();
    }

    public void Hard()
    {
        // Thiết lập độ khó Hard
        GameManager.Instance.SetDifficulty(10f, 15f, 5f);
        RestartGame();
    }

    private void RestartGame()
    {
        pauseMenu.SetActive(false); // Tắt menu tạm dừng
        Time.timeScale = 1; // Trả lại tốc độ game về bình thường
        GameManager.Instance.NewGame(); // Gọi hàm khởi động lại game
    }
}