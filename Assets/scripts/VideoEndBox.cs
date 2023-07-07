using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Threading.Tasks;


public class VideoEndBox : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public GameObject VideotoLoad;
    public GameObject VideotoStop;
    public GameObject TagToLoad;

    public GameObject audio_tomidle;
    public GameObject audio_box;




    void Start()
    {
        VideoPlayer.loopPointReached += LoadNewVideo;
    }

    void LoadNewVideo(VideoPlayer vp)
    {
        VideotoLoad.SetActive(true);
        TagToLoad.SetActive(true);

        audio_tomidle.SetActive(true);
        audio_box.SetActive(false);

        VideotoStop.SetActive(false);
       
    }
}