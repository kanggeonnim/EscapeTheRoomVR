using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    private bool isOpen = false; // 문 열림 상태 여부

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (isOpen)
        {
            animator.SetBool("isOpenAni", true);
            // 문 열림 애니메이션 재생 등, 문 열리는 동작 처리
            Debug.Log("문이 열렸습니다.");
            isOpen = true;
        }
    }
}
