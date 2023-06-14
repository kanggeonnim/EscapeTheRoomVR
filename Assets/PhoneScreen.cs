using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PhoneScreen : MonoBehaviour
{
    private MeshRenderer Mrenderer;
    // Start is called before the first frame update
    private VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        Mrenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame

    public void startCount()
    {
        Mrenderer.material.color = Color.white;
        videoPlayer.Play();
    }
    public void stopCount()
    {
        Mrenderer.material.color = Color.black;
        videoPlayer.Stop();
    }
}
