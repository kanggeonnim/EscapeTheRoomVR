using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    public Rigidbody doorRigidbody;  // 문의 Rigidbody 컴포넌트를 가리키는 변수

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Key")  // 충돌한 오브젝트가 열쇠인 경우
        {
            doorRigidbody.constraints = RigidbodyConstraints.None;
        }
    }

}
