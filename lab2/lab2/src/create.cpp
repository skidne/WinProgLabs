#include "header.h"

void wmCreate(HINSTANCE hInst, HWND hwnd, HWND hw[], int pos[]) {
	WNDCLASSEXW wc = { 0 };
	wc.cbSize = sizeof(WNDCLASSEXW);
	wc.lpfnWndProc = (WNDPROC)DialogProc;
	wc.hInstance = hInst;
	wc.hbrBackground = CreateSolidBrush(BLACK);
	wc.lpszClassName = L"DialogClass";
	RegisterClassExW(&wc);

	hw[0] = CreateWindow("button", "CLICK ME", WS_VISIBLE | WS_CHILD,
		0, 0, 0, 0, hwnd, (HMENU)ID_BTN_DOME, NULL, NULL);

	hw[1] = CreateWindow("scrollbar", "",
		WS_VISIBLE | WS_CHILD | SBS_HORZ,
		0, 0, 0, 0,
		hwnd, (HMENU)ID_SCRCOL, NULL, NULL);

	SetScrollRange(hw[1], SB_CTL, pos[0], pos[2], FALSE);
	SetScrollPos(hw[1], SB_CTL, pos[0], TRUE);

	hw[2] = CreateWindow("scrollbar", "",
		WS_VISIBLE | WS_CHILD | SBS_HORZ,
		0, 0, 0, 0,
		hwnd, (HMENU)ID_SCRSIZ, NULL, NULL);

	SetScrollRange(hw[2], SB_CTL, pos[4], pos[5], FALSE);
	SetScrollPos(hw[2], SB_CTL, pos[3], TRUE);

	hw[3] = CreateWindow("scrollbar", "",
		WS_VISIBLE | WS_CHILD | SBS_HORZ,
		0, 0, 0, 0,
		hwnd, (HMENU)ID_SCRSIZ, NULL, NULL);

	SetScrollRange(hw[3], SB_CTL, pos[4], pos[5], FALSE);
	SetScrollPos(hw[3], SB_CTL, pos[6], TRUE);
}
