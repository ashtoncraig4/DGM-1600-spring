using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;

    void Start ()
    (
        while(cupsInTheSink > 0)
        (
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        )
    )
}

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
    
    void Start ()
    (
        for(int 1 = 0: 1 < numEnemies; 1++)
        (
            Debug.Log("Creating enemy number: " + 1);
        )
    )
}

public class ForeachLoop : Mono Behavior
{
    void Start ()
    (
        string[] strings = new string(3);
 
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Thrid string";
        
    )
}
