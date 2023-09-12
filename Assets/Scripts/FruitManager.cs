using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitManager : MonoBehaviour {

    // Game Object referido al texto de victoria
    public GameObject victoryTextPrefab;

    // Mostrar dicho Game Object
    public void ShowVictoryText()
    {
        GameObject victoryText = Instantiate(victoryTextPrefab);
        victoryText.SetActive(true);
        victoryText.transform.position = new Vector3(0.77f, 0.44f, -1.0f);
    }

    // Si todas las frutas del nivel fueron recolectadas,
    // se muestra texto de victoria
    public void AllFruitsCollected() {
        if (transform.childCount <= 1) {
            Debug.Log("No apples left. VICTORY!");

            if (victoryTextPrefab) {
                ShowVictoryText();
            }
        }
    }
}
