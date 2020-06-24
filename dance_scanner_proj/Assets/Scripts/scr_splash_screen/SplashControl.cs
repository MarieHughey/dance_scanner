using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashControl : MonoBehaviour
{

    public GameObject loadingDot;

    public SpriteRenderer dot1;
    public SpriteRenderer dot2;
    public SpriteRenderer dot3;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Invoke("load1", 1.0f);
        Invoke("load2", 2.0f);
        Invoke("load3", 3.0f);
        */
        Invoke("loadmenu", 6.0f);

        StartCoroutine("load1in");
        StartCoroutine("load2in");
        StartCoroutine("load3in");
        StartCoroutine("fade1out");
        StartCoroutine("fade2out");
        StartCoroutine("fade3out");
    }

    void loadmenu()
    {
        SceneManager.LoadScene(sceneName:"menu_scene");
    }

    IEnumerator load1in()
    {
        dot1.enabled = false;
        yield return new WaitForSeconds(1);
        dot1.enabled = true;
        float duration = 1f;
        SpriteRenderer MyRenderer = dot1;
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(0, 1, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }

    }
    IEnumerator load2in()
    {
        dot2.enabled = false;
        yield return new WaitForSeconds(2);
        dot2.enabled = true;
        float duration = 1f;
        SpriteRenderer MyRenderer = dot2;
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(0, 1, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }

    }

    IEnumerator load3in()
    {
        dot3.enabled = false;
        yield return new WaitForSeconds(3);
        dot3.enabled = true;
        float duration = 1f;
        SpriteRenderer MyRenderer = dot3;
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(0, 1, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }

    }

    IEnumerator fade1out()
    {
        yield return new WaitForSeconds(4);
        float duration = 2.0f;
        SpriteRenderer MyRenderer = dot1;
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(1, 0, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }
        dot1.enabled = false;
    }

    IEnumerator fade2out()
    {
        yield return new WaitForSeconds(4);
        float duration = 2.0f;
        SpriteRenderer MyRenderer = dot2;
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(1, 0, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }

        dot2.enabled = false;
    }

    IEnumerator fade3out()
    {
        yield return new WaitForSeconds(4);
        float duration = 2.0f;
        SpriteRenderer MyRenderer = dot3;
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(1, 0, counter / duration);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }
        dot3.enabled = false;
    }


    /*
    void load1()
    {
        GameObject loadingDot1 = Instantiate(loadingDot, new Vector3(-1.0f, -3.55f, 0f), loadingDot.transform.rotation);
        Destroy(loadingDot1, 3.0f);
    }

    void load2()
    {
        GameObject loadingDot2 = Instantiate(loadingDot, new Vector3(0f, -3.55f, 0f), loadingDot.transform.rotation);
        Destroy(loadingDot2, 2.0f);
    }

    void load3()
    {
        GameObject loadingDot3 = Instantiate(loadingDot, new Vector3(1.0f, -3.55f, 0f), loadingDot.transform.rotation);
        Destroy(loadingDot3, 1.0f);
    }
    */
}
