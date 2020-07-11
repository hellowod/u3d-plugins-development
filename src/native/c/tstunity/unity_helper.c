#define TST_LIB

#include "unity_helper.h"

CSFunction function;

TST_API void reg_func(CSFunction func){
    function = func;
}

TST_API void call_func() {
    function();
}