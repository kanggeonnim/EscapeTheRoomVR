using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    private bool isOpen = false; // �� ���� ���� ����

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
            // �� ���� �ִϸ��̼� ��� ��, �� ������ ���� ó��
            Debug.Log("���� ���Ƚ��ϴ�.");
            isOpen = true;
        }
    }
}
