/*
config
*/

#if defined(_MSC_VER)
#define TST_API __declspec(dllexport)
#else
#define TST_API
#endif