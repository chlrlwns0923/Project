using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnouncementScript : MonoBehaviour
{

    public Transform user_transform;

    // Start is called before the first frame update
    void Start()
    {
        var userscript = user_transform.GetComponent<User>();

        if(userscript.is_start == false)
        {
            Debug.Log("캐릭터를 생성하세요!!");  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
