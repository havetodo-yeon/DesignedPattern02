using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PMyHpObserver : MonoBehaviour, PObserver
{
    GameObject obj;

    public Slider slider;



    public PMyHpObserver(GameObject gameObject)
    {
        this.obj = gameObject;
    }

    public void PObserverUpdate(float myHp, float enemyHP)
    {
        
        slider.
        obj.gameObject.GetComponent<HPPSubject>().SetHP(Slider.value);
        Debug.Log("[옵저버 1] 실행 완료");
        Debug.Log($"오브젝트를 통해 얻어온 값 : {value}");
        Debug.Log($"매개변수 값 : {number}");
    }
}
