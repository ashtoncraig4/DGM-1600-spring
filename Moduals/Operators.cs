using UnityEngine;
using SystemCollections;

public class Operators : MonoBehavior {
        public int valueOne = 5;
        public int valueTwo = 2;
        private float mod;

        // Use this for initialization
        void Start () {

        }
        
        // Update is called once per frame
        void Update () {

        }

        // Addition is adding multiple numbers together to get the sum
        Debug.Log(valueOne + valueTwo);
        // Modulus like devision but rounds the remainder.
        Debug.Log(valueOne % valueTwo);
        // Multiplication will multiply numbers together.
        Debug.Log(valueOne * valueTwo);
        // Divison will divide one number by another.
        Debug.Log(valueOne / valueTwo);
        // Subtraction will take away the amount of the second number from the first and the remainder is your sum
        Debug.Log(valueOne - valueTwo);
        // Increment a quick way to repeditively increase by a set number like one or two
        Debug.Log(valueOne ++ valueTwo);
        // Decrement a quick way to repeditively decrease by a set number like one or two
        Debug.Log(valueOne -- valueTwo);
        }

}        