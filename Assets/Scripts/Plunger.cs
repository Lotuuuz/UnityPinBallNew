using UnityEngine;

public class Plunger : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private AudioClip bumperSFX;
    [SerializeField] private Transform ballSpawnPoint;

    public SoundManager soundManager;
    public GameManager gameManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    void FireCannon()
    {
        // Block firing if a ball is already active
        if (gameManager.ballInPlay == true)
            return;

        // Block firing if the game is over
        if (gameManager.gameOver == true)
            return;


        GameObject ball = Instantiate(ballPrefab, ballSpawnPoint.transform.position, ballSpawnPoint.transform.rotation);
        ball.GetComponent<Rigidbody>().linearVelocity = ballSpawnPoint.transform.forward * ballSpeed;

        gameManager.ballInPlay = true;
     //   soundManager.PlaySFX(bumperSFX);
    }
}