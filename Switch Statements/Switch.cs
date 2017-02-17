using UnityEngine;
using System.Collections;

public class Switch : MonoBehavior
{
    public int intelligence = 5;

    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("text")
                break;
            case 4:   
                print()
                break;
            case 3:
                print()
                break;
            case 2:
                print()
                break;
            case 1:
                print()
                break;    
        } 

    }
}