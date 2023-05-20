using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This is a CLASS, to declare it only has to have 2 parameters, really.

//'class' signifies that this is a CLASS
//then the NAME, for example 'ClassTeach'
//That's all the parameters it has to have to be a CLASS,
//and it's in that order.

//It also can have a MODIFIER there's multiple modifiers including:
//public means something can be accessed by the entire program, 
//static means there's
//only one instance of something in the entire program and etc.

//What comes after the name is INHERITANCE, it needs a ':'
//before it, for example, how 'ClassTech' extends 'InterfaceTeach'.

//LOCATION: line below is declaration of the CLASS.
public class ClassTeach : InterfaceTeach
{
    //LOCATION: Inside the class
    //Here you can declare variables wich the class object will
    //have for example 'double dolares = 0d'.
    //Variables CAN have modifiers
    public double dolar = 0d;

    //This is a method, it needs only 3 parameters to be one.

    //The type it returns after executing for example 'void'
    //wich returns nothing, the name for example 'ClassFunctions'
    //and '()' with the arguments to call them for example 'int valor'.
    //Arguments

    //Just like classes functions can have modifiers.
    public void ClassFunction(int valor)
    {
        //LOCATION: Inside method
        //a method may be able to be declared inside another
        //method but NEVER DO SO, as only things inside it
        //will be able to access it. In fact, NOTHING
        //inside this method will be accessible outside of it.
    }

    //Remember the INTERFACE this CLASS inherits?
    //All CLASSes that inherit INTERFACEs need
    //to implement their methods, exactly as
    //described on the INTERFACE.

    void InterfaceMethod1()
    {
        int l = 0;
        //l now is now 10.
        l = InterfaceMethod2(5);
    }
    int InterfaceMethod2(int value)
    {
        return  value * 2;
    }
    void InterfaceMethod3()
    {

    }
}