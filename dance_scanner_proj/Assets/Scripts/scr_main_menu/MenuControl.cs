using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public SpriteRenderer spriteToFade;
    public bool buffered = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("fadeOut");
        StartCoroutine("buffer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator buffer()
    {
        yield return new WaitForSeconds(0.5f);
        buffered = true;
    }

    IEnumerator fadeIn()
    {
        float duration = 1.0f;
        SpriteRenderer MyRenderer = spriteToFade;
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

        spriteToFade.enabled = false;
    }

    IEnumerator fadeOut()
    {
        spriteToFade.enabled = true;
        float duration = 1.0f;
        SpriteRenderer MyRenderer = spriteToFade;
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

        spriteToFade.enabled = false;
    }

    IEnumerator loadsettings()
    {
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene(sceneName:"settings_scene");
    }

    IEnumerator loadsaved()
    {
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene(sceneName:"saved_vids_scene");
    }

    void OnMouseDown()
    {
        if (buffered)
        {
            if(gameObject.name == "analyze_button")
            {
                Debug.Log("Clicked Analyze");
            }

            else if (gameObject.name == "saved_button")
            {
                Debug.Log("Clicked Saved");
                StartCoroutine("fadeIn");
                StartCoroutine("loadsaved");
            }

            else if (gameObject.name == "settings")
            {
                Debug.Log("Clicked Settings");
                StartCoroutine("fadeIn");
                StartCoroutine("loadsettings");
            }
        }
    }
}
