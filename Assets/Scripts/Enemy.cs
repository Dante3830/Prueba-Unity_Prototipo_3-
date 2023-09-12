using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Referencia al Audio Source
    public AudioSource audioSource;

    // Sonido de daño
    public AudioClip hitSFX;

    // Game Object referido al texto de derrota
    public GameObject gameOverTextPrefab;

    // Mostrar dicho Game Object
    public void ShowGameOverText() {
        GameObject gameOverText = Instantiate(gameOverTextPrefab);
        gameOverText.SetActive(true);
        gameOverText.transform.position = new Vector3(0.48f, 0.44f, -1.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // Si el personaje se colisiona con el enemigo,
        // el personaje desaparece
        if (collision.transform.CompareTag("Player")) {
            Debug.Log("Player Damaged");

            if (audioSource.isPlaying) {
                return;
            }

            // Ejecuta sonido de daño
            audioSource.PlayOneShot(hitSFX);

            // Elimina el objeto que colisiona (el jugador)
            Destroy(collision.gameObject);

            // Muestra mensaje de derrota por consola
            Debug.Log("GAME OVER");

            if (gameOverTextPrefab) {
                ShowGameOverText();
            }
        }
    }
}
