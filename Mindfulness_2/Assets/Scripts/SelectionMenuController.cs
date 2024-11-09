using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionMenuController : MonoBehaviour
{
    public void Option1Selected()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Option2Selected()
    {
        SceneManager.LoadScene("Scene2");
    }
}

