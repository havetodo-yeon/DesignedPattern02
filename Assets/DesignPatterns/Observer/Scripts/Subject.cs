using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
    // 대상, 주체를 의미하는 인터페이스
    // 옵저버에 대한 관리와 활용 관련괸 코드들을 가지고 있습니다.
{
    void Subscribe(Observer observer);
    void UnSubscribe(Observer observer);
    void Notify();


}
