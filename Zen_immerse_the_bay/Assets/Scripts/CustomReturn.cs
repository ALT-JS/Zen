using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CustomReturn : MonoBehaviour {
    public InputActionReference toggleReference = null;

    private void Awake() {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy() {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context) {
        SceneManager.LoadScene("Menu");
    }
}

