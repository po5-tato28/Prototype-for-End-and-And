using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeboxManager : MonoBehaviour
{
    [SerializeField] List<Material> origin; // 텍스쳐를 저장할 list
    [SerializeField] List<int> correct; // 정답을 저장
    [SerializeField] List<int> safeboxA;
    [SerializeField] List<int> safeboxB;

    List<int> arr;  // correct에 값을 부여할 때 사용할 때 사용

    private void Awake()
    {
        correct = new List<int>();
        arr = new List<int>();
    }

    private void Start()
    {
        SetCorrect();
    }

    public void SetCorrect()
    {
        // 컨테이너 비우기
        if (correct.Count > 0)
        {
            correct.Clear();
        }

        // arr에 origin의 index를 할당한다.
        for (int i = 0; i < origin.Count; i++)
        {
            arr.Add(i);
        }        
        
        int value;
        int cnt = 0;

        // arr의 원소 개수가 0보다 클 때까지 반복
        while (0 < arr.Count)
        {
            // correct에 arr의 값을 '랜덤으로' 하나씩 할당
            value = arr[Random.Range(0, arr.Count)];
            correct.Add(value);

            // 할당 받은 correct의 값을 arr에서 삭제한다.
            arr.Remove(correct[cnt]);
            // cnt = index를 증가
            cnt++;
        }        
    }

    void SetSafebox()
    {

    }
    
}
