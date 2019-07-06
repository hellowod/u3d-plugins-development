#ifndef SORT_HELPER_
#define SORT_HELPER_

#include "sys/time.h"

int val=0;

static int RetInt();

int RetIntSlow();
int RetSqrtC();
int diff_ms(timeval t1, timeval t2);
void TestIntC(int numMillions);

void mono_internal_initialize();

#endif//SORT_HELPER_
