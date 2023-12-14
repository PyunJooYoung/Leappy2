using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAScene : MonoBehaviour
{
   public void LoadHomeScene()
    {
        SceneManager.LoadScene("HomeScene");
    }
    public void LoadNightmareScene()
    {
        SceneManager.LoadScene("NightmareScene");
    }
    public void LoadOutsideScene()
    {
        SceneManager.LoadScene("OutsideScene");
    }
}
