using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashControl : MonoBehaviour
{

    public GameObject loadingDot;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("load1", 1.0f);
        Invoke("load2", 2.0f);
        Invoke("load3", 3.0f);
        Invoke("loadmenu", 4.0f);
    }

    void loadmenu()
    {
        SceneManager.LoadScene(sceneName:"menu_scene");
    }

    void load1()
    {
        GameObject loadingDot1 = Instantiate(loadingDot, new Vector3(-1.0f, -3.55f, 0f), loadingDot.transform.rotation);
    }

    void load2()
    {
        GameObject loadingDot2 = Instantiate(loadingDot, new Vector3(0f, -3.55f, 0f), loadingDot.transform.rotation);
    }

    void load3()
    {
        GameObject loadingDot3 = Instantiate(loadingDot, new Vector3(1.0f, -3.55f, 0f), loadingDot.transform.rotation);
    }
}
