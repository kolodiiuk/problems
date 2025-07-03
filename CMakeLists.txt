cmake_minimum_required(VERSION 3.31)
project(untitled4)

set(CMAKE_CXX_STANDARD 20)

add_executable(untitled4 main.cpp
        leetcode/448_find_all_numbers_disappeared_in_an_array.cpp
        leetcode/344_reverse_string.cpp
        codewars/bit_counting.cpp
        codewars/playing_with_digits.cpp
        codewars/functions_of_integers_on_cartesian_plane.c
        codewars/find_all_occurences_of_an_element_in_an_array.c
        codewars/case_sensitive.cpp
        codewars/detect_pangram.cpp
)
