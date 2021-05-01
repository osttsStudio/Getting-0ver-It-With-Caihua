using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FullButton1080 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Switch to 1920 x 1080 full-screen
        // 设置为无边框全屏1920*1080
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update () {

    }
}
