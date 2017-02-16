/*
config
*/

#if defined(TST_LIB)
#define TST_API __declspec(dllexport)
#else
#define TST_API __declspec(dllimport)
#endif