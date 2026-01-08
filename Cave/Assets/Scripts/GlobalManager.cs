using UnityEngine;
using System.Collections;


public class GlobalManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);//родитель никогда не будет уничтожен
    }
}
