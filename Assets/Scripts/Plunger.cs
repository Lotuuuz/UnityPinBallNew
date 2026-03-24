

using UnityEngine;

public class Plunger : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private AudioClip bumperSFX;

    public SoundManager soundManager;
    public GameManager gameManager; // NEW: reference to GameManager

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    void FireCannon()
    {
        // NEW: block firing if a ball already exists
        if (gameManager.ballInPlay == true)
            return;

        GameObject ballSpawnPoint = GameObject.Find("BallSpawnPoint");
        GameObject ball = Instantiate(ballPrefab, ballSpawnPoint.transform.position, ballSpawnPoint.transform.rotation);
        ball.GetComponent<Rigidbody>().linearVelocity = ballSpawnPoint.transform.forward * ballSpeed;

        gameManager.ballInPlay = true; // NEW: mark ball as active
        //soundManager.PlaySFX(bumperSFX);
    }
}