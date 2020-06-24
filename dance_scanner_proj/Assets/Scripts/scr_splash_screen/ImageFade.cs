using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFade : MonoBehaviour {
 
    public SpriteRenderer spriteToFade;

    void Start()
    {
        Debug.Log("starting");
        StartCoroutine("fadeIn");
        StartCoroutine("fadeOut");
    }

    IEnumerator fadeIn()
    {
        float duration = 3.0f;
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

    }

    IEnumerator fadeOut()
    {
        yield return new WaitForSeconds(4);
        float duration = 2.0f;
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
}