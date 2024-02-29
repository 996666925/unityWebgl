using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public GameObject backgroundMale;

    public GameObject live2dMale;

    public GameObject live2dFemale;

    public GameObject backgroundFemale;
    public GameObject vfx_firework;
    public GameObject vfx_sukura;

    public float intensity;
    public SpriteRenderer spriteRenderer;
    public Material mat;
    public Color c;

    private void Start()
    {
        //SwitchToFemale();
        intensity = 5;
        mat = spriteRenderer.material;
        c = mat.GetColor("_EmissionColor");
        StartCoroutine(LightShake());

        //SwitchToFemale();
    }

    public void SetIntensity(float _intensity)
    {
        float factor = Mathf.Pow(2, _intensity);
        mat.SetColor("_EmissionColor",new Color(c.r*factor,c.g*factor,c.b*factor));
    }

    /// <summary>
    /// make the sprite light and dark
    /// </summary>
    /// <returns></returns>
    IEnumerator LightShake()
    {
        intensity = 0;
        bool Isincrease = true;
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if (Isincrease)
            {
                intensity += 0.05f;
                SetIntensity(intensity);
                if (intensity >= 3f)
                    Isincrease = false;
            }
            else
            {
                intensity -= 0.1f;
                SetIntensity(intensity);
                if (intensity <= 0)
                    Isincrease = true;
            }
            
        }
    }

    public void SwitchToMale()
    {
        backgroundFemale.SetActive(false);
        backgroundMale.SetActive(true);
        live2dFemale.SetActive(false);
        live2dMale.SetActive(true);
        vfx_firework.SetActive(true);
        vfx_sukura.SetActive(false);
        
    }

    public void SwitchToFemale()
    {
        backgroundFemale.SetActive(true);
        backgroundMale.SetActive(false);
        live2dFemale.SetActive(true);
        live2dMale.SetActive(false);
        vfx_firework.SetActive(false);
        vfx_sukura.SetActive(true);
    }
    // public GameObject cube;
    // public InputField inputField;
    // [DllImport("__Internal")]
    // private static extern void Hello();
    //
    // [DllImport("__Internal")]
    // private static extern void HelloString(string str);
    //
    // [DllImport("__Internal")]
    // private static extern float HelloFloat();
    // Start is called before the first frame update
    // void Start()
    // {
    //     
    // }
    //
    // // /// <summary>
    // // /// called by React native
    // // /// </summary>
    // // public void ToUnity()
    // // {
    // //     cube.transform.Rotate(Vector3.up,30);
    // // }
    //
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
