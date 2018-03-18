#include "header.h"

int WINAPI WinMain(HINSTANCE hThisInstance, HINSTANCE hPrevInstance, LPSTR lpszArgument, int nCmdShow) {
	HWND		hwnd;
	MSG			messages;
	WNDCLASSEX	wincl;

	wincl.hInstance = hThisInstance;
	wincl.lpszClassName = "lab2";
	wincl.lpfnWndProc = WinProc;
	wincl.style = CS_DBLCLKS | CS_HREDRAW | CS_VREDRAW;
	wincl.cbSize = sizeof(WNDCLASSEX);
	wincl.hIcon = LoadIcon(hThisInstance, MAKEINTRESOURCE(IDI_ICON1));
	wincl.hIconSm = LoadIcon(hThisInstance, MAKEINTRESOURCE(IDI_ICON2));
	wincl.hCursor = LoadCursor(hThisInstance, MAKEINTRESOURCE(IDC_CURSOR1));
	wincl.lpszMenuName = MAKEINTRESOURCE(IDR_MENU1);
	wincl.cbClsExtra = 0;
	wincl.cbWndExtra = 0;
	wincl.hbrBackground = CreateSolidBrush(BLACK);

	if (!RegisterClassEx(&wincl))
		return 0;

	hwnd = CreateWindowEx(
		0,
		"lab2",
		"Voldemort vs Pizza",
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		400,
		400,
		HWND_DESKTOP,
		NULL,
		hThisInstance,
		NULL
	);

	ShowWindow(hwnd, nCmdShow);

	while (GetMessage(&messages, NULL, 0, 0)) {
		TranslateMessage(&messages);
		DispatchMessage(&messages);
	}
	return messages.wParam;
}

LRESULT CALLBACK WinProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) {
	static HINSTANCE	hInst;
	static HWND hw[4];
	static int pos[] = {0, 0, 255, 400, 400, 600, 400};

	switch (message) {

	case WM_CREATE:
		wmCreate(hInst, hwnd, hw, pos);
		break;

	case WM_SIZE:
		wmSize(hwnd, hw);
		break;

	case WM_HSCROLL:
		wmHscroll(pos, lParam, wParam, hwnd, hw);
		break;

	case WM_COMMAND:
		wmCommand(wParam, hwnd, hInst);
		break;

	case WM_SYSKEYDOWN:
		if (GetKeyState(VK_MENU) < 0 && GetKeyState(VK_UP) < 0)
			SendMessage(hwnd, WM_SYSCOMMAND, SC_MAXIMIZE, 0);
		if (GetKeyState(VK_MENU) < 0 && GetKeyState(VK_DOWN) < 0)
			SendMessage(hwnd, WM_SYSCOMMAND, SC_MINIMIZE, 0);
		break;

	case WM_GETMINMAXINFO:
		((LPMINMAXINFO)lParam)->ptMinTrackSize.x = 400;
		((LPMINMAXINFO)lParam)->ptMinTrackSize.y = 400;
		((LPMINMAXINFO)lParam)->ptMaxTrackSize.x = 600;
		((LPMINMAXINFO)lParam)->ptMaxTrackSize.y = 600;
		break;

	case WM_PAINT:
		wmPaint(hwnd);
		break;

	case WM_DESTROY:
		PostQuitMessage(0);
		break;

	default:
		return DefWindowProc(hwnd, message, wParam, lParam);

	}
	return 0;
}