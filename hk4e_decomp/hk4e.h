#pragma once

#include <cstdint>

#ifdef HK4E_DECOMP_EXPORTS
#define HK4E_API __declspec(dllexport)
#else
#define HK4E_API __declspec(dllimport)
#endif

extern "C" HK4E_API int DecryptBlb(uint8_t*, size_t, uint8_t*, size_t, unsigned int);