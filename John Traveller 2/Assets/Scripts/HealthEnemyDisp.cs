using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemyDisp : MonoBehaviour
{

    Enemy _enemy;
    public Slider _slider;
    
    void Start()
    {
        _enemy = this.gameObject.transform.parent.gameObject.transform.parent.gameObject.GetComponent<Enemy>();
        _slider.maxValue = _enemy.hpMax;
        _slider.value = _enemy.hp;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = _enemy.hp;
    }
}
