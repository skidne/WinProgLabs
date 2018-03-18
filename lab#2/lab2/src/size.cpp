#include "header.h"

void wmSize(HWND hwnd, HWND hw[]) {
	RECT rect;
	GetClientRect(hwnd, &rect);

	SetWindowPos(hw[0], HWND_TOP,
		rect.right / 2.4, rect.bottom / 6,
		100, 25,
		SWP_NOZORDER
	);

	SetWindowPos(hw[1], HWND_TOP,
		rect.right / 3, rect.bottom / 1.3,
		200, 25,
		SWP_NOZORDER
	);

	SetWindowPos(hw[2], HWND_TOP,
		rect.right / 3, rect.bottom / 1.19,
		200, 25,
		SWP_NOZORDER
	);
	SetWindowPos(hw[3], HWND_TOP,
		rect.right / 3, rect.bottom / 1.1,
		200, 25,
		SWP_NOZORDER
	);
}