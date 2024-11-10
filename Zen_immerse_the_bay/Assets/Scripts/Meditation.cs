using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Meditation : MonoBehaviour {
    public InputActionReference toggleReference = null;
    public AudioSource musicSource;

    private void Awake() {
        toggleReference.action.started += ToggleMusic;
    }

    private void OnDestroy() {
        toggleReference.action.started -= ToggleMusic;
    }

    private void ToggleMusic(InputAction.CallbackContext context) {
        musicSource.Play();
    }
}

