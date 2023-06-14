using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RayCast : MonoBehaviour
{
    private float gazeDuration = 0f;
    private bool isTVPlaying = false;
    private bool isPsPlaying = false;
    private bool isGazing = false;

    [SerializeField] LayerMask layermask;
    [SerializeField] TV tv;
    [SerializeField] PhoneScreen ps;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f, layermask))
        {
            if (isPsPlaying == false && isTVPlaying == false)
            {
                ps.startCount();
                isPsPlaying = true;
            }

            Debug.Log("Hit Something");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.red);

            gazeDuration += Time.deltaTime;

            Debug.Log(gazeDuration);

            if (gazeDuration >= 3f && isTVPlaying == false)
            {
                tv.PlayVideo();
                isTVPlaying = true;
            }
        }
        else
        {
            if (isTVPlaying == false)
            {
                gazeDuration = 0;
            }
            if(isPsPlaying == true)
            {
                ps.stopCount();
                isPsPlaying = false;
            }
            Debug.Log("Hit Nothing");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.green);
        }
    }
}
