using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour {

    public AudioSource audioSource;

    public AudioClip collisionSFX;

    // Detecta la colisión entre la manzana y el jugador
    private void OnTriggerEnter2D(Collider2D collision) {
        // Si hay colision, el Sprite Renderer de la manzana se desactiva
        if (collision.CompareTag("Player")) {
            GetComponent<SpriteRenderer>().enabled = false;

            // Agarra el primer hijo y muestra animación de recolección
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            if (audioSource.isPlaying) {
                return;
            }

            // Ejecuta sonido de colisión
            audioSource.PlayOneShot(collisionSFX);

            // Verifica si no quedan frutas
            FindAnyObjectByType<FruitManager>().AllFruitsCollected();

            // Finalmente, destruye el objeto en 0.5 segundos
            Destroy(gameObject, 0.5f);
        }        
    }
}