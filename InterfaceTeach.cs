using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This is an INTERFACE it's simply a bunch of
//methods a CLASS must make.

//LOCATION: line below is declaration of the INTERFACE.
public interface InterfaceTeach
{
    //LOCATION: inside interface

    //Methods in interfaces are declared
    //almost just like in classes,
    //the only difference is that they have no
    //code. Instead, they end in ';'.
    void InterfaceMethod1();
    int InterfaceMethod2(int value);
    void InterfaceMethod3();
}