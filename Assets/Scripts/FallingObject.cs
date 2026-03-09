using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Coin"))
            {
                ScoreManager.instance.AddScore(1);
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Bomb"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}