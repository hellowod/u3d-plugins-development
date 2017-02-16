cmake_minimum_required(VERSION 2.8)

project(TstUnity)

include_directories(
	TstUnity
)

set ( TSTUNITY_CORE 
	TstUnity/math_helper.c
	TstUnity/sort_helper.c 
)

if (APPLE)
    if (IOS)
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD)")
        add_library(tstunity STATIC
           ${TSTUNITY_CORE}
        )
    else ()
        set(CMAKE_OSX_ARCHITECTURES "$(ARCHS_STANDARD_32_64_BIT)")
        add_library(tstunity MODULE
            ${TSTUNITY_CORE}
        )
        set_target_properties ( tstunity PROPERTIES BUNDLE TRUE )
    endif ()
else ( )
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
