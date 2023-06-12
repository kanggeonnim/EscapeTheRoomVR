using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawersMove : MonoBehaviour
{
    private Renderer _renderer;
    private Material originalMaterial;
    private Material selectMaterial;

    private bool isClosed = true;
    private bool isAnimationPlaying = false;

    private Vector3 closedPosition;
    private Vector3 opendPosition;

    public float animPlayTime = 0.5f;
    public float animDistance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = this.GetComponent<Renderer>();
        originalMaterial = _renderer.material;
        selectMaterial.color = new Color(0f, 1f, 0f);

        closedPosition = this.transform.position;
        opendPosition = this.transform.position - Vector3.forward * animDistance;
    }

    // Update is called once per frame
    public void HoverIn()
    {
        _renderer.material = selectMaterial;
    }

    public void HoverOut()
    {
        _renderer.material = originalMaterial;
    }

    public void Selet()
    { 
        Debug.Log("Drawer Selected...");
        if(isClosed)
        {
            if(!isAnimationPlaying)
            {
                isAnimationPlaying = true;
                StartCoroutine("PlayOpeningAnimation");
            }  
        }
        else
        {
            if(!isAnimationPlaying)
            {
                isAnimationPlaying = false;
            }     
        }
    }
    IEnumerator PlayOpeningAnimation()
    {
        float curTime = 0f;
        while (curTime / animPlayTime < 1.0f)
        {
            curTime += Time.deltaTime;
            Vector3 currentPos = Vector3.Lerp(closedPosition, opendPosition, curTime / animPlayTime);
            this.transform.position = currentPos;
            yield return null;
        }
        isAnimationPlaying = false;
        isClosed = false;
    }
}
