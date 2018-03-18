#include "header.h"

void colorScroll(int pos[], WPARAM wParam, HWND hwnd, HWND hw[]) {
	switch (LOWORD(wParam)) {

	case SB_LINERIGHT:
		pos[0] += 1;
		break;

	case SB_LINELEFT:
		pos[0] -= 1;
		break;

	case SB_PAGERIGHT:
		pos[0] += 10;
		break;

	case SB_PAGELEFT:
		pos[0] -= 10;
		break;

	case SB_THUMBTRACK:
		pos[0] = HIWORD(wParam);
		break;

	case SB_TOP:
		pos[0] = pos[1];
		break;

	case SB_BOTTOM:
		pos[0] = pos[2];
		break;

	}
	SetScrollPos(hw[1], SB_CTL, pos[0], TRUE);
	bkgColor(hwnd, pos[0]);
}

void widthScroll(int pos[], WPARAM wParam, HWND hwnd, HWND hw[]) {
	RECT rect;
	GetWindowRect(hwnd, &rect);
	pos[3] = rect.right - rect.left;

	switch (LOWORD(wParam)) {

	case SB_LINERIGHT:
		pos[3] += 3;
		break;

	case SB_LINELEFT:
		pos[3] -= 3;
		break;

	case SB_PAGERIGHT:
		pos[3] += 10;
		break;

	case SB_PAGELEFT:
		pos[3] -= 10;
		break;

	case SB_THUMBTRACK:
		pos[3] = HIWORD(wParam);
		break;

	case SB_TOP:
		pos[3] = pos[4];
		break;

	case SB_BOTTOM:
		pos[3] = pos[5];
		break;

	}
	SetScrollPos(hw[2], SB_CTL, pos[3], TRUE);
	MoveWindow(hwnd, rect.left, rect.top, pos[3], rect.bottom - rect.top, TRUE);
}

void heightScroll(int pos[], WPARAM wParam, HWND hwnd, HWND hw[]) {
	RECT rect;
	GetWindowRect(hwnd, &rect);
	pos[6] = rect.bottom - rect.top;

	switch (LOWORD(wParam)) {

	case SB_LINERIGHT:
		pos[6] += 3;
		break;

	case SB_LINELEFT:
		pos[6] -= 3;
		break;

	case SB_PAGERIGHT:
		pos[6] += 10;
		break;

	case SB_PAGELEFT:
		pos[6] -= 10;
		break;

	case SB_THUMBTRACK:
		pos[6] = HIWORD(wParam);
		break;

	case SB_TOP:
		pos[6] = pos[4];
		break;

	case SB_BOTTOM:
		pos[6] = pos[5];
		break;

	}
	SetScrollPos(hw[3], SB_CTL, pos[6], TRUE);
	MoveWindow(hwnd, rect.left, rect.top, rect.right - rect.left, pos[6], TRUE);
}

void wmHscroll(int pos[], LPARAM lParam, WPARAM wParam, HWND hwnd, HWND hw[]) {
	if ((HWND)lParam == hw[1])
		colorScroll(pos, wParam, hwnd, hw);
	if ((HWND)lParam == hw[2])
		widthScroll(pos, wParam, hwnd, hw);
	if ((HWND)lParam == hw[3])
		heightScroll(pos, wParam, hwnd, hw);
}