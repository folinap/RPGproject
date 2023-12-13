using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyState : MonoBehaviour
{
   public abstract EnemyState RunCurrentState();    

    // Update is called once per frame
    void Update()
    {
        
    }
}
