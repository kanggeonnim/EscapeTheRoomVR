using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_handle : MonoBehaviour
{
    public Door targetDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key") // �浹�� ������Ʈ�� ������ ���
        {
            Debug.Log("���� ���Ƚ��ϴ�.");
            targetDoor.OpenDoor(); // ���� ������ ȣ��
        }
    }
}
