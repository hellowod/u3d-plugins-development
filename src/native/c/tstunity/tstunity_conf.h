/*
conf
*/

#if defined _WIN32
    #if LIBTST_BUILD
        #define TST_API __declspec(dllexport)
    #else
        #define TST_API __declspec(dllimport)
    #endif
#else
    #define TST_API
#endif

typedef void (*CSFunction)();
