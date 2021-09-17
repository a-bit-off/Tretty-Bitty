using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gManager : MonoBehaviour
{
    public GameObject bladeTarget;
    public void ChangeScene(int number)
    {
        SceneManager.LoadScene(number);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void CloseFreeMode()
    {
        Camera.main.GetComponent<CamRotation>().enabled = false;
        if (SceneManager.GetActiveScene().buildIndex == 0)
            bladeTarget.SetActive(true);
    }
    public void FreeMode()
    {
        Camera.main.GetComponent<CamRotation>().enabled = true;
        if (SceneManager.GetActiveScene().buildIndex == 0)
            bladeTarget.SetActive(false);
    }
}
