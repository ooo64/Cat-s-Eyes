using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameOverScreen instance;

    private PlayerHealth playerHealthRef;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.LogWarning("There's more than one GameOverManager in the scene");
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    void Start()
    {
        playerHealthRef = Object.FindFirstObjectByType<PlayerHealth>();
        if (playerHealthRef == null)
        {
            Debug.LogError("PlayerHealth script not found in the scene!");
        }
    }

    public void OnPlayerDeath()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RetryButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);

        // Si vous aviez une méthode Respawn dans PlayerHealth, vous l'appelleriez ici:
        // if (playerHealthRef != null)
        // {
        //     playerHealthRef.Respawn(); 
        // }
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}