#include "header.h"

char buff[256] = "Eat ";

LRESULT CALLBACK DialogProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam) {
	static HWND hwndListBox, hwndBtn;
	static HINSTANCE hInst;

	switch (msg) {

	case WM_CREATE:
		hwndListBox = CreateWindow("listbox", "Who",
			WS_VISIBLE | WS_CHILD | LBS_STANDARD | LBS_NOTIFY,
			20, 20, 80, 50, hwnd, (HMENU)ID_LSTBOX, hInst, NULL);
		SendMessage(GetDlgItem(hwnd, ID_LSTBOX), LB_ADDSTRING, NULL, (LPARAM)"Hitler");
		SendMessage(GetDlgItem(hwnd, ID_LSTBOX), LB_ADDSTRING, NULL, (LPARAM)"Pizza");
		SendMessage(GetDlgItem(hwnd, ID_LSTBOX), LB_ADDSTRING, NULL, (LPARAM)"Voldemort");

		hwndBtn = CreateWindow("button", "Bon Appetit!",
			BS_PUSHBUTTON | BS_CENTER | WS_CHILD | WS_VISIBLE,
			100, 120, 90, 25, hwnd, (HMENU)ID_BTN_BONAPP, hInst, NULL);
		break;

	case WM_COMMAND:
		if (LOWORD(wParam) == ID_LSTBOX && HIWORD(wParam) == LBN_SELCHANGE) {
			int index = SendMessage(hwndListBox, LB_GETCURSEL, 0, 0);
			SendMessage(hwndListBox, LB_GETTEXT, (WPARAM)index, (LPARAM)buff + 4);
			InvalidateRect(hwnd, NULL, TRUE);
		}
		if (LOWORD(wParam) == ID_BTN_BONAPP)
			DestroyWindow(hwnd);
		break;

	case WM_PAINT:
		dialogPaint(hwnd, buff);
		break;

	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;

	}
	return (DefWindowProcW(hwnd, msg, wParam, lParam));
}
