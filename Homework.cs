using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public float speed = 0.2f;

    public float maxCount = 50.0f; //초기 빈도 값
    int count = 0;//카운터용
    bool flipFlag = false;//참 거짓을 판단하기 위해 bool 데이터형 사용

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))//down 눌렀을때만, up 떼었을때
        {
            transform.Translate(speed, 0, 0);
        }

        else if (Input.GetMouseButtonUp(0)) //GetMouseButten에서 0은 왼쪽마우스, 1은 오른쪽마우스 2는 휠

        {
            transform.Translate(-speed, 0, 0);
        }
        count = count + 1;
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, 180);//회전을 한다.
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;//스프라이터 랜더러라는 컴퍼넌트에 있는 속성에 있는 플립Y라는 속성에 flipFlag값을 대입한다.
        }
    }
}