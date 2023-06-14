using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour
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
    public void PlayVideo()
    {
        Mrenderer.material.color = Color.white;
        videoPlayer.Play();
    }
}
