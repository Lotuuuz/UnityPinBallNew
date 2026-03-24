using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int ballsLeft = 3;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private TMP_Text ballCountText;
    [SerializeField] private GameObject gameOverScreen;

    public bool ballInPlay = false; // NEW: tracks if a ball is active

    private void Start()
    {
        ballCountText.text = ballsLeft.ToString();
        Debug.Log("ballsleft: " + ballsLeft);
    }

    public void BallLost()
    {
        ballsLeft--;
        ballCountText.text = ballsLeft.ToString();
        ballInPlay = false; // NEW: allow spawning a new ball

        if (ballsLeft > 0)
        {
            // If you want auto‑respawn, uncomment this:
            //Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}