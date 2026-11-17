using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //adding a public variable to the class
    public int alpha = 5;

   // adding a private variable to the class
    private int beta = 0;

    private int gamma = 5;



    private AnotherClass myOtherClass;



    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();


        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
        
    }


    public void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log("The answer is: " + answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
        
    }
}
