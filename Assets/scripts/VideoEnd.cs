using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Threading.Tasks;


public class VideoEnd : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public GameObject VideotoLoad;
    public GameObject VideotoStop;
    public GameObject TagToLoad; 
    public GameObject ButtonShow;
    public GameObject audio_steam;


    void Start()
    {
        VideoPlayer.loopPointReached += LoadNewVideo;
    }

    void LoadNewVideo(VideoPlayer vp)
    {
        VideotoLoad.SetActive(true);
        TagToLoad.SetActive(true);
        ButtonShow.SetActive(true);
        VideotoStop.SetActive(false);
        audio_steam.SetActive(false);
    }
}