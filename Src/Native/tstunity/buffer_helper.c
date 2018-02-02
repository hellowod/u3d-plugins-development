#define TST_LIB

#include <stdio.h>

#include "sort_helper.h"

static int RetInt()
{
    val++;
    return val;
}

int RetIntSlow()
{
    val++;
    return val;
}

int RetSqrtC()
{
    val++;
    return sqrt(val);
}

int diff_ms(timeval t1, timeval t2)
{
    return (((t1.tv_sec - t2.tv_sec) * 1000000) +
            (t1.tv_usec - t2.tv_usec))/1000;
}

void TestIntC(int numMillions)
{
    timeval start, finish;
    gettimeofday(&start,NULL);
    
    int total=0;        
    for (long count = 0; count <numMillions*1000000; count++)
    {
        for (long count2 = 0; count2 <100; count2++)
        {
            total+=RetSqrtC();
        }
    }
    
    gettimeofday(&finish,NULL);
    printf("\nTotal %d",total); //Using total, so the compiler doesn't optimize and gets rid of the code above.
    printf("\nSpent %d ms",diff_ms(finish, start));        
    
}

void mono_internal_initialize()
{ 
    mono_add_internal_call("Hello::RetInt", (void*)RetInt);
}
