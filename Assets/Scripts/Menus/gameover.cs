/*using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar; // Barre de vie
    public int maxHealth = 100;
    private int currentHealth;

    public AudioClip hitSound; // Son de perte de vie
    public AudioClip gameOverMusic; // Musique de game over
    private AudioSource audioSource;

    private bool isGameOver = false;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();

        // Ajoute automatiquement un AudioSource si absent
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            UpdateHealthBar();

            // Joue le son de dégât
            if (hitSound != null && !audioSource.isPlaying)
            {
                audioSource.PlayOneShot(hitSound);
            }

            // Si la vie tombe à zéro → Game Over
            if (currentHealth <= 0 && !isGameOver)
            {
                GameOver();
            }
        }
    }

    void UpdateHealthBar()
    {
        float fillAmount = (float)currentHealth / maxHealth;
        healthBar.fillAmount = fillAmount;
    }

    void GameOver()
    {
        isGameOver = true;

        // Coupe tous les autres sons
        audioSource.Stop();

        // Joue la musique de game over en boucle
        if (gameOverMusic != null)
        {
            audioSource.clip = gameOverMusic;
            audioSource.loop = true; // → Active la boucle
            audioSource.Play();
        }

        // Affiche l'écran de game over (exemple)
        Debug.Log("GAME OVER !");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }
}
*/