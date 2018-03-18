#ifndef HEADER__H
#define HEADER__H

#include <Windows.h>
#include "resource.h"

#define ID_LSTBOX 1000
#define ID_BTN_BONAPP 1001
#define ID_BTN_DOME 1002
#define ID_SCRCOL 1003
#define ID_SCRSIZ 1004

#define BLACK RGB(0, 0, 0)
#define WHITE RGB(255, 255, 255)
#define BLUE RGB(66, 244, 229)

LRESULT CALLBACK DialogProc(HWND, UINT, WPARAM, LPARAM);
LRESULT CALLBACK WinProc(HWND, UINT, WPARAM, LPARAM);
void wmCreate(HINSTANCE, HWND, HWND[], int[]);
void wmSize(HWND hwnd, HWND hw[]);
void wmPaint(HWND);
void wmCommand(WPARAM wParam, HWND hwnd, HINSTANCE hInst);
void dialogPaint(HWND hwnd, char buff[]);
void bkgColor(HWND hwnd, int pos);
void wmHscroll(int pos[], LPARAM lParam, WPARAM wParam, HWND hwnd, HWND hw[]);

#endif // !HEADER__H
