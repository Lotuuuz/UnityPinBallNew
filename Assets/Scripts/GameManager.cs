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

    public bool gameOver = false;
    public bool ballInPlay = false;

    private void Start()
    {
        ballCountText.text = ballsLeft.ToString();
        Debug.Log("ballsleft: " + ballsLeft);
    }

    public void BallLost()
    {
        ballsLeft--;
        ballCountText.text = ballsLeft.ToString();
        ballInPlay = false;

        if (ballsLeft > 0)
        {
            // If you want auto‑respawn, uncomment this:
            //Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            gameOver = true; // IMPORTANT: block plunger from firing
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}