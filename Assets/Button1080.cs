using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button1080 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Switch to 640 x 480
        // 设置为窗口化1920*1080
        Screen.SetResolution(1920, 1080, false);
    }

    // Update is called once per frame
    void Update () {

    }
}
