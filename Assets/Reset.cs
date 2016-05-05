using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    public void ButtonReset()
    {
        Application.LoadLevel("main");

    }

}
