using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class FadeOut : MonoBehaviour
{
    public CanvasGroup panel;
    public float fadeDuration;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PanelFadeOut());
    }
    System.Collections.IEnumerator PanelFadeOut()
    {
        float elapsed = 0f;
        yield return new WaitForSeconds(0.3f);
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            panel.alpha = alpha;
            yield return null;
        }

        panel.gameObject.SetActive(false);
    }
}
