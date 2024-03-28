using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSubject : MonoBehaviour, Subject
{
    List<Observer> observers = new List<Observer>();    // 옵저버들을 관리하는 List
    private int number;

    public int getNumber() { return number; }

    private void Start()
    {
        number = 5;

        var observer1 = new Observer1(gameObject);
        var observer2 = new Observer2(gameObject);

        Subscribe(observer1);
        Subscribe(observer2);

    }

    /// <summary>
    /// 관리중인 옵저버들에게 연락을 하는 기능을 가진 메소드
    /// </summary>
    /// <exception cref="System.NotImplementedException"></exception>
    public void Notify()
    {
        foreach(Observer observer in observers)
        {
            observer.OnNotify(number);
        }
    }

    public void Subscribe(Observer observer)
    {
        observers.Add(observer);
    }

    public void UnSubscribe(Observer observer)
    {
        // 전달받은 옵저버의 인덱스 번호가 0보다 크다면
        if (observers.IndexOf(observer) > 0)
        {
            observers.Remove(observer);
        }
    }
}
