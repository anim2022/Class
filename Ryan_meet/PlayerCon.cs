using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCon : MonoBehaviour
{
    float speed = 0; //오브젝트가 이동하기위한 
    Vector2 startPos; //2차원좌표의 벡터(x,y) 3차원의 벡터값(x,y,z)//Vector2는 2차원좌표의 값을 갖습니다.(x,y) Vecter3 (x,y,z)
    Vector2 endPos; //마우스 클릭했을 때 위치값이 들어갈 변수 
    public float 분모값 = 1000.0f; //분모값
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //마우스 왼 클릭을 한다면
        { 
            this.startPos = Input.mousePosition; //마우스로 클릭한 좌표
        }
        else if(Input.GetMouseButtonUp(0)) //마우스에서 손가락을 떼었을 때 좌표
        {
            Vector2 endPos = Input.mousePosition; //마우스버튼을 눌렀다가 때었을 때의 좌표
            float Length = (endPos.x - this.startPos.x); //endpos-startpos의 값은 이동속도로 이용할 것, 그리고 이값은 lenth에 대입할 것. length 변수는 speed 변수에 대입할 것이다. 
           this.speed = Length / 20.0f; //length값은 speed값에 대입한다. speed값은 Translate x에 대입하여 오브젝트를 이동하게한다.
           this.GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed * Time.deltaTime, 0, 0);//이동 -x+방향으로
        this.speed *= 0.98f;//감속시킨다 최대한 천천히 (순간이동한것처럼 보이지 않게하려고)
    }
}
