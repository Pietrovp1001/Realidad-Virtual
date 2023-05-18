using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public Material material;
    
    public Color ChargedColor;
    public Color endColor;
    public Color originalColor;
    
    private bool isChangingColorShot = false;
    public float duration = 1f;
    private float timeElapsed = 0f;

    void Awake()
    {
        material.SetColor("_EmissionColor", originalColor);
    }

    void Update()
    {
        if (isChangingColorShot)
        {
            timeElapsed += Time.deltaTime;
            float t = Mathf.Clamp01(timeElapsed / duration);
            Color newColor = Color.Lerp(ChargedColor, endColor, t);
            material.SetColor("_EmissionColor", newColor);
            if (t == 1f)
            {
                isChangingColorShot = false;
            }
        }
    }

    public void ChangeColorShot()
    {
        isChangingColorShot = true;
        timeElapsed = 0f;
    }
    
    public void ChangeReload()
    {
        material.SetColor("_EmissionColor", ChargedColor);
    }

    public void ResetColor()
    {
        isChangingColorShot = false;
        material.SetColor("_EmissionColor", ChargedColor);
    }
}
