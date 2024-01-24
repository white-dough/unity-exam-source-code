using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private PlayerStatic playerObject;

    [SerializeField]
    private ScoreManager scoreText;

    public float speed = 10f;

    private void Start()
    {
        playerObject = GameObject.FindWithTag("Player").GetComponent<PlayerStatic>();
        scoreText = GameObject.FindWithTag("Score").GetComponent<ScoreManager>();
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            scoreText.scoreCount += 1;
            gameObject.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            playerObject.setHealth(-1f);

        }
    }

    void OnEnable()
    {
        transform.position = Vector3.zero;
    }
}
