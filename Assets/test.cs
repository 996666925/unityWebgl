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

    private void Start()
    {
        SwitchToMale();
        //SwitchToFemale();
    }

    public void SwitchToMale()
    {
        backgroundFemale.SetActive(false);
        backgroundMale.SetActive(true);
        live2dFemale.SetActive(false);
        live2dMale.SetActive(true);
        
    }

    public void SwitchToFemale()
    {
        backgroundFemale.SetActive(true);
        backgroundMale.SetActive(false);
        live2dFemale.SetActive(true);
        live2dMale.SetActive(false);
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