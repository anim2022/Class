using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//유니티의 UI를 사용하려면 꼭 입력.


public class GameDirec : MonoBehaviour
{
    GameObject player;//플레이어 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject Ryan;//목표물 오브젝트를 대입할 변수 데이터형 GameObject
    GameObject distance;//플레이어 오브젝트와 목표물 오브젝트사이의 거리를 표시할 UI 오브젝트를 대입할 변수 데이터형 Game object
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("swordman");
        this.Ryan = GameObject.Find("Ryan"); //목표물 오브젝트를 대입할 변수 데이터형 GameObject
        this.distance = GameObject.Find("이동거리");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.Ryan.transform.position.x - this.player.transform.position.x;//이동거리 계산 
        if (lengthDis >= 0)//만약 0보다 크거나 같다면
        {
            this.distance.GetComponent<Text>().text = "목표지점" + ":" + lengthDis.ToString("F5") + "m";
            //ToString("D숫자") 정수형,숫자는 자리수
        }
        else//lengthDis가 0보다 값이 작아졌다면
        {
            this.distance.GetComponent<Text>().text = "Game Over!!!";
        }
    }
}

