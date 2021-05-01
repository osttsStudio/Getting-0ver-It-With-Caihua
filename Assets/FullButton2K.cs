using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FullButton2K : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Switch to 2560 x 1440 full-screen
        // 设置为无边框全屏2560*1440
        Screen.SetResolution(2560, 1440, true);
    }

    // Update is called once per frame
    void Update () {

    }
}
