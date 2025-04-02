using UnityEngine;

public class Alien : MonoBehaviour
{
    public GameObject explosionEffect;
    public AudioClip explosionSound;
    private AudioSource audioSource;
    private GameManager gameManager;

    void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnMouseDown()
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        audioSource.PlayOneShot(explosionSound);
        gameManager.AddScore(1);
        Destroy(gameObject);
    }
}
