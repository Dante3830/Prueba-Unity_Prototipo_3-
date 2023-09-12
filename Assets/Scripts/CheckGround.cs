using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {

    // Chequea si el personaje está en el piso
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision) {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision) {
        isGrounded = false;
    }
}
