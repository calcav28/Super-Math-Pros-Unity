using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MathTwoOperation

{
    public float firstNumber;
    public float secondNumber;
    public MathOperations operation;
    public float[] answers;
    
    [Range (0,3)]
    public int correctAnswer;
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }


}


public enum MathOperations
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}
