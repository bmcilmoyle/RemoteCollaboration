using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scene Management required
using UnityEngine.SceneManagement;

public class AdditiveSceneLoading : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Cubes", LoadSceneMode.Additive);
            SceneManager.LoadScene("Capsules", LoadSceneMode.Additive);
        }
    }
}
