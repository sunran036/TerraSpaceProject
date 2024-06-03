using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TreeEditor;

public class Skills : MonoBehaviour
{
    float skilltime;

    public Player player;
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void Start()
    {
        
    }

    public void SpeedSkill() {
        StartCoroutine(SuperSpeed());
    }

    IEnumerator SuperSpeed()
    {
        // 속도를 5배로 증가시킴
        player.moveSpeed *= 5.0f;

        // 4초 대기
        yield return new WaitForSeconds(4.0f);

        // 원래 속도로 되돌림
        player.moveSpeed /= 5.0f;
    }
}
