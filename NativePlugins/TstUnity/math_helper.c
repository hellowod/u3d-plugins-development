#include "math_helper.h"

__declspec(dllexport) int add(int a, int b){
	return a + b;
}

__declspec(dllexport) int sub(int a, int b){
	return a - b;
}

__declspec(dllexport) int div(int a, int b){
	return a / b;
}

__declspec(dllexport) int mul(int a, int b){
	return a * b;
}