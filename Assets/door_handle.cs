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
        if (collision.gameObject.name == "Key") // 충돌한 오브젝트가 열쇠인 경우
        {
            Debug.Log("문이 열렸습니다.");
            targetDoor.OpenDoor(); // 문을 열도록 호출
        }
    }
}
