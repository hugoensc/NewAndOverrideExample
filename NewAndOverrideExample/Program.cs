﻿using System;

namespace NewAndOverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1();
            bc.Method2();
            dc.Method1();
            dc.Method2();
            bcdc.Method1();
            bcdc.Method2();
        }
    }
}
