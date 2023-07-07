using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Threading.Tasks;


public class VideoEndTomato : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public GameObject VideotoLoad;
    public GameObject VideotoStop;

    public GameObject audio_vrisidle;
    public GameObject audio_tomatoflow;


    public GameObject TagToLoad;
   
    public GameObject ButtonShow;


    void Start()
    {
        VideoPlayer.loopPointReached += LoadNewVideo;
    }

    void LoadNewVideo(VideoPlayer vp)
    {
        VideotoLoad.SetActive(true);
        audio_vrisidle.SetActive(true);
        audio_tomatoflow.SetActive(false);
        TagToLoad.SetActive(true);
        ButtonShow.SetActive(true);
        VideotoStop.SetActive(false);
      
    }
}