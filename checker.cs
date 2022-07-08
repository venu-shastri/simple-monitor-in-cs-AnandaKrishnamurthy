using System;
using System.Diagnostics;


class Checker

{
  
    public static bool temperatureIsOk(float temperature)
    {
      if (temperature< 0 || temperature> 45)
        {
            Console.WriteLine("Temperature is out of range!");
            return false;
        }
            return true;
    }


    public static bool socIsOk(float soc)
    {
        if (soc < 20 || soc > 80)
        {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        }
            return true;
    }

    public static bool chargeRateIsOk(float chargeRate)
    {
        if (chargeRate > 0.8)
        {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
       
            return true;
    }

    static bool batteryIsOk float temperature,  float soc,  float chargeRate, /* Array Of Function Pointers */ Func<float,bool> parameterVerifiers)
    {

        /* iterate Through  Function Pointers Array , apply each function pointer*/
     Delegate[] array= parameterVerifiers.GetInvocationList();
    }

    public static void IsExpectTrueOk(bool expression)
    {
        if (!expression)
        {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
        static void ExpectTrue(Action<bool> IsExpectTrueOk, bool expression)
    {
        IsExpectTrueOk(expression);
    }
    static void IsExpectFalseOk(bool expression)
    {
        if (expression)
        {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }

    static void ExpectFalse(Action<bool> IsExpectFalseOk, bool expression)
    {
        IsExpectFalseOk(expression);
    }




    static int Main()
    {
      //Array of Function Pointers
      Func<float,bool> _parameterVarifierFunctionObjects=new Func<float,bool>(temperatureIsOk);
      _parameterVarifierFunctionObjects+=Func<float,bool>(socIsOk);
      _parameterVarifierFunctionObjects+=Func<float,bool>(chargeRateIsOk);
      
      
        ExpectTrue(IsExpectTrueOk, batteryIsOk(25,70, 0.7f,_parameterVarifierFunctionObjects);
        ExpectFalse(IsExpectFalseOk,batteryIsOk(temperatureIsOk,50, socIsOk, 85, chargeRateIsOk, 0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
}

