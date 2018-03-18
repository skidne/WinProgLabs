#include "header.h"

void wmPaint(HWND hwnd) {
	PAINTSTRUCT ps;
	HDC hdc;
	RECT rect;

	hdc = BeginPaint(hwnd, &ps);

	GetClientRect(hwnd, &rect);
	SetBkMode(hdc, TRANSPARENT);
	SetTextColor(hdc, BLUE);
	DrawText(hdc, "Only God knows the purpose of this app", -1, &rect, DT_SINGLELINE | DT_CENTER | DT_VCENTER);

	EndPaint(hwnd, &ps);
}

void dialogPaint(HWND hwnd, char buff[]) {
	PAINTSTRUCT ps;
	HDC hdc;
	RECT rect;

	hdc = BeginPaint(hwnd, &ps);

	GetClientRect(hwnd, &rect);
	SetBkMode(hdc, TRANSPARENT);
	SetTextColor(hdc, WHITE);
	rect.left = 110;
	rect.top = 30;
	DrawText(hdc, buff, -1, &rect, DT_SINGLELINE | DT_NOCLIP);

	EndPaint(hwnd, &ps);
}

void bkgColor(HWND hwnd, int pos) {
	PAINTSTRUCT ps;
	RECT r;

	GetClientRect(hwnd, &r);

	HDC hdc = BeginPaint(hwnd, &ps);
	SetClassLong(hwnd, GCL_HBRBACKGROUND, (LONG)CreateSolidBrush(RGB(pos, pos, pos)));
	InvalidateRect(hwnd, NULL, TRUE);

	EndPaint(hwnd, &ps);
}
