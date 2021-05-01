using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
 
public class BGM : MonoBehaviour
{
 
    public AudioMixer audioMixer;    // 进行控制的Mixer变量
 
    public void SetMasterVolume(float volume)    // 控制主音量的函数
    {
        audioMixer.SetFloat("Master", volume);
        // MasterVolume为我们暴露出来的Master的参数
    }

    public void SetBGMVolume(float volume)    // 控制背景音乐音量的函数
    {
        audioMixer.SetFloat("BGM", volume);
        // MusicVolume为我们暴露出来的Music的参数
    }

}