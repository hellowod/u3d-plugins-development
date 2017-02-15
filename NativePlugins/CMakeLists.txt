cmake_minimum_required(VERSION 2.8)

project(TstUnity)

include_directories(
	TstUnity
)

set ( TST_CORE TstUnity/math_helper.c TstUnity/sort_helper.c )

if (APPLE)
    if (IOS)
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD)")
        add_library(tstunity STATIC
           ${TST_CORE}
        )
    else ()
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD_32_64_BIT)")
        add_library(tstunity MODULE
            ${TST_CORE}
        )
        set_target_properties ( tstunity PROPERTIES BUNDLE TRUE )
    endif ()
else ( )
    add_library(tstunity SHARED
        ${TST_CORE}
    )
endif ( )

if ( WIN32 AND NOT CYGWIN )
    target_compile_definitions (tstunity PRIVATE LUA_BUILD_AS_DLL)
endif ( )

if(UINT_ESPECIALLY)
    ADD_DEFINITIONS(-DUINT_ESPECIALLY)
endif()
	
if ( WIN32 AND NOT CYGWIN )
    target_link_libraries(tstunity
		ws2_32
		${THIRDPART_LIB} 
    )
else ( )
    target_link_libraries(tstunity
		m
		${THIRDPART_LIB} 
	)
endif ( )
