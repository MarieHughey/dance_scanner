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
        float duration = 2.0f;
        SpriteRenderer MyRenderer = spriteToFade;
        Debug.Log("in fade out");
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            Debug.Log("doing this");
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(0, 1, counter / duration);
            Debug.Log(alpha);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }

    }

    IEnumerator fadeOut()
    {
        yield return new WaitForSeconds(2);
        float duration = 2.0f;
        SpriteRenderer MyRenderer = spriteToFade;
        Debug.Log("in fade out");
        float counter = 0;
        //Get current color
        Color spriteColor = MyRenderer.material.color;

        while (counter < duration)
        {
            Debug.Log("doing this");
            counter += Time.deltaTime;
            //Fade from 1 to 0
            float alpha = Mathf.Lerp(1, 0, counter / duration);
            Debug.Log(alpha);

            //Change alpha only
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            //Wait for a frame
            yield return null;
        }

    }
}