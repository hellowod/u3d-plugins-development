cmake_minimum_required(VERSION 2.8)

project(tstunity)

include_directories(
	tstunity
)

set ( TSTUNITY_CORE 
	tstunity/math_helper.c
	tstunity/unity_helper.c
)

if (APPLE)
    if (IOS)
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD)")
        add_library(tstunity STATIC
           ${TSTUNITY_CORE}
        )
    else ()
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD_64_BIT)")
        add_library(tstunity MODULE
            ${TSTUNITY_CORE}
        )
        set_target_properties ( tstunity PROPERTIES BUNDLE TRUE )
    endif ()
else ( )
	add_definitions("-DLIBTST_BUILD")
    add_library(tstunity SHARED
        ${TSTUNITY_CORE}
    )
endif ( )
	
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