using UnityEngine;

public class Ex_DeathTrigger : MonoBehaviour
{
    //public GameManager gameManager;
    [SerializeField] private GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            gameManager.BallLost();
        }
    }
}