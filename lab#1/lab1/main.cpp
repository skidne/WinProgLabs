#include <windows.h>
#include <stdlib.h>

#define ID_BTN_RICK 100
#define ID_BTN_MORTY 101
#define ID_BTN_POOP 102
#define ID_BTN_ADD 103
#define ID_BTN_SUBMIT 104
#define ID_TXT_CHAR 105
#define ID_TXT_NAME 106

LRESULT CALLBACK WinProc(HWND, UINT, WPARAM, LPARAM);

char		szClassName[] = "VSWindowsApp";
char		txtChosen[100] = "Your Favorite Character:  Choose a character";
const char	txtTitle[] = "Rick and Morty: Favorite Character Poll";
HINSTANCE	hInst;

int WINAPI WinMain(HINSTANCE hThisInstance, HINSTANCE hPrevInstance, LPSTR lpszArgument, int nCmdShow) {
	HWND		hwnd;
	MSG			messages;
	WNDCLASSEX	wincl;

	/* The Window structure */
	wincl.hInstance = hThisInstance;
	wincl.lpszClassName = szClassName;
	wincl.lpfnWndProc = WinProc;
	wincl.style = CS_DBLCLKS | CS_HREDRAW | CS_VREDRAW;
	wincl.cbSize = sizeof(WNDCLASSEX);
	wincl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wincl.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	wincl.hCursor = LoadCursor(NULL, IDC_ARROW);
	wincl.lpszMenuName = NULL;
	wincl.cbClsExtra = 0;
	wincl.cbWndExtra = 0;
	wincl.hbrBackground = CreateSolidBrush(RGB(0, 0, 0));

	/* Register the window class, and if it fails quit the program */
	if (!RegisterClassEx(&wincl))
		return 0;

	/* The class is registered, let's create the program*/
	hwnd = CreateWindowEx(
		0,                   /* Extended possibilites for variation */
		szClassName,         /* Classname */
		"Rick & Morty Poll", /* Title Text */
		WS_OVERLAPPEDWINDOW, /* default window */
		CW_USEDEFAULT,       /* Windows decides the position */
		CW_USEDEFAULT,       /* where the window ends up on the screen */
		640,                 /* The programs width */
		480,                 /* and height in pixels */
		HWND_DESKTOP,        /* The window is a child-window to desktop */
		NULL,                /* No menu */
		hThisInstance,       /* Program Instance handler */
		NULL                 /* No Window Creation data */
	);

	/* Make the window visible on the screen */
	ShowWindow(hwnd, nCmdShow);

	/* Run the message loop. It will run until GetMessage() returns 0 */
	while (GetMessage(&messages, NULL, 0, 0)) {
		TranslateMessage(&messages);
		DispatchMessage(&messages);
	}

	return messages.wParam;
}

/*  This function is called by the Windows function DispatchMessage()  */
LRESULT CALLBACK WinProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) {
	HDC		hdc;
	RECT	rect;
	HFONT	hFont;
	SIZE	txtSz;

	static HWND			hwndBtnRick, hwndBtnMorty, hwndBtnPoop,
						hwndBtnAdd, hwndBtnSubmit, hwndTxtChar,
						hwndTxtName, hwndName, hwndChar;
	PAINTSTRUCT			ps;
	LPDRAWITEMSTRUCT	lps;
	static COLORREF		color = RGB(255, 255, 255);

	switch (message) {

	/* called when a window is created */
	case WM_CREATE:
		GetClientRect(hwnd, &rect);

		hwndBtnRick = CreateWindow("button", "Rick",
			BS_PUSHBUTTON | BS_CENTER | WS_CHILD | WS_VISIBLE | BS_OWNERDRAW,
			0, 0, 0, 0, hwnd, (HMENU)ID_BTN_RICK, hInst, NULL);

		hwndBtnMorty = CreateWindow("button", "Morty",
			BS_PUSHBUTTON | BS_CENTER | WS_CHILD | WS_VISIBLE | BS_OWNERDRAW,
			0, 0, 0, 0, hwnd, (HMENU)ID_BTN_MORTY, hInst, NULL);

		hwndBtnPoop = CreateWindow("button", "Mr. Poopybutthole",
			BS_PUSHBUTTON | BS_CENTER | WS_CHILD | WS_VISIBLE | BS_OWNERDRAW,
			0, 0, 0, 0, hwnd, (HMENU)ID_BTN_POOP, hInst, NULL);

		hwndBtnAdd = CreateWindow("button", "Add",
			BS_PUSHBUTTON | BS_CENTER | WS_CHILD | WS_VISIBLE,
			0, 0, 0, 0, hwnd, (HMENU)ID_BTN_ADD, hInst, NULL);

		hwndBtnSubmit = CreateWindow("button", "Submit",
			BS_PUSHBUTTON | BS_CENTER | WS_CHILD | WS_VISIBLE | BS_OWNERDRAW,
			0, 0, 0, 0, hwnd, (HMENU)ID_BTN_SUBMIT, hInst, NULL);

		hwndTxtChar = CreateWindow("edit", "",
			WS_EX_CLIENTEDGE | WS_CHILD | WS_VISIBLE,
			0, 0, 0, 0, hwnd, (HMENU)ID_TXT_CHAR, hInst, NULL);

		hwndTxtName = CreateWindow("edit", "",
			WS_EX_CLIENTEDGE | WS_CHILD | WS_VISIBLE,
			0, 0, 0, 0, hwnd, (HMENU)ID_TXT_NAME, hInst, NULL);

		hwndChar = CreateWindow("static", "Or type here:",
			WS_CHILD | WS_VISIBLE | BS_CENTER,
			0, 0, 0, 0, hwnd, (HMENU)NULL, hInst, NULL);

		hwndName = CreateWindow("static", "Enter your name:",
			WS_CHILD | WS_VISIBLE | BS_CENTER,
			0, 0, 0, 0, hwnd, (HMENU)NULL, hInst, NULL);

		break;

	/* called on window resize */
	case WM_SIZE:
		GetClientRect(hwnd, &rect);

		SetWindowPos(hwndBtnRick, HWND_TOP,
			rect.right / 10, rect.bottom / 6,
			rect.right / 8, rect.bottom / 10,
			SWP_NOZORDER
		);

		SetWindowPos(hwndBtnMorty, HWND_TOP,
			rect.right / 4, rect.bottom / 6,
			rect.right / 5, rect.bottom / 10,
			SWP_NOZORDER
		);

		SetWindowPos(hwndBtnPoop, HWND_TOP,
			rect.right / 2.1, rect.bottom / 6,
			rect.right / 2.2, rect.bottom / 10,
			SWP_NOZORDER
		);

		SetWindowPos(hwndBtnAdd, HWND_TOP,
			rect.right / 1.5, rect.bottom / 3,
			rect.right / 10, rect.bottom / 20,
			SWP_NOZORDER
		);

		SetWindowPos(hwndBtnSubmit, HWND_TOP,
			rect.right / 2.4, rect.bottom / 1.2,
			rect.right / 6, rect.bottom / 10,
			SWP_NOZORDER
		);

		SetWindowPos(hwndTxtChar, HWND_TOP,
			rect.right / 2.65, rect.bottom / 3,
			rect.right / 4, rect.bottom / 20,
			SWP_NOZORDER
		);

		SetWindowPos(hwndTxtName, HWND_TOP,
			rect.right / 2.5, rect.bottom / 1.5,
			rect.right / 5, rect.bottom / 15,
			SWP_NOZORDER
		);

		SetWindowPos(hwndChar, HWND_TOP,
			rect.right / 5, rect.bottom / 3,
			rect.right / 6, rect.bottom / 20,
			SWP_NOZORDER
		);

		SetWindowPos(hwndName, HWND_TOP,
			rect.right / 5.3, rect.bottom / 1.5,
			rect.right / 5, rect.bottom / 15,
			SWP_NOZORDER
		);

		break;

	/* called when a button is pressed */
	case WM_COMMAND:
		switch (wParam) {

		case ID_BTN_RICK:
			color = RGB(0, 255, 177);
			strcpy(txtChosen + 26, "Rick Sanchez");
			InvalidateRect(hwnd, NULL, TRUE);

			PlaySound("headBentOver.wav", NULL, SND_FILENAME | SND_ASYNC);
			break;

		case ID_BTN_MORTY:
			color = RGB(255, 0, 165);
			strcpy(txtChosen + 26, "Morty Smith");
			InvalidateRect(hwnd, NULL, TRUE);

			PlaySound("mainTheme.wav", NULL, SND_FILENAME | SND_ASYNC);
			break;

		case ID_BTN_POOP:
			color = RGB(255, 178, 0);
			strcpy(txtChosen + 26, "Mr. Poopybutthole");
			InvalidateRect(hwnd, NULL, TRUE);

			PlaySound("getSchwifty.wav", NULL, SND_FILENAME | SND_ASYNC);
			break;

		case ID_BTN_ADD:
			char tmp[40];

			GetWindowText(GetDlgItem(hwnd, ID_TXT_CHAR), tmp, 40);

			if (strcmp(tmp, "")) {
				strcpy(txtChosen + 26, tmp);
				InvalidateRect(hwnd, NULL, TRUE);
			}
			else
				MessageBox(hwnd, "Please enter your favorite character's name.",
					"Error", MB_OK);

			color = RGB(250, 250, 250);
			break;

		case ID_BTN_SUBMIT:
			GetWindowText(GetDlgItem(hwnd, ID_TXT_NAME), tmp, 40);

			if (strcmp(tmp, "")) {
				if (strcmp(txtChosen + 26, "Choose a character")) {
					MessageBox(hwnd, "Thank you for taking your time to complete this poll.",
						"Submit Window", MB_OK);
					PostQuitMessage(0);
				}
				else
					MessageBox(hwnd, "You haven't chosen a favorite character!",
						"Error Window", MB_OK);
			}
			else
				MessageBox(hwnd, "Please enter your name.", "Error Window", MB_OK);
			break;

		}
		break;

	/* customize static text */
	case WM_CTLCOLORSTATIC:
		hdc = (HDC)wParam;

		SetTextColor(hdc, RGB(250, 250, 250));
		SetBkColor(hdc, RGB(0, 0, 0));

		return (INT_PTR)CreateSolidBrush(RGB(0, 0, 0));

	/* customize input text */
	case WM_CTLCOLOREDIT:
		if (GetDlgCtrlID((HWND)lParam) == ID_TXT_NAME) {
			hdc = (HDC)wParam;

			SetBkColor(hdc, RGB(0, 138, 165));
			SetTextColor(hdc, RGB(250, 250, 250));
			hFont = (HFONT)SelectObject(hdc, CreateFont(17, 8, 0, 0, FW_BOLD,
				0, 0, 0, 0, 0, 0, ANTIALIASED_QUALITY, 0, "Comic Sans MS"));

			return (INT_PTR)CreateSolidBrush(RGB(0, 138, 165));
		}
		break;

	/* customize buttons */
	case WM_DRAWITEM:
		switch (wParam) {

		case ID_BTN_RICK:
			lps = (DRAWITEMSTRUCT*)lParam;
			hFont = (HFONT)SelectObject(lps->hDC, CreateFont(22, 15, 0, 0, FW_BOLD,
				0, 0, 0, 0, 0, 0, PROOF_QUALITY, 0, "Rockwell"));
			GetTextExtentPoint32(lps->hDC, "Rick", 4, &txtSz);

			SetBkColor(lps->hDC, RGB(0, 255, 177));
			SetTextColor(lps->hDC, RGB(0, 79, 55));

			ExtTextOut(lps->hDC,
				(lps->rcItem.right - lps->rcItem.left - txtSz.cx) / 2,
				(lps->rcItem.bottom - lps->rcItem.top - txtSz.cy) / 2,
				ETO_CLIPPED | ETO_OPAQUE, &lps->rcItem, "Rick", 4, NULL
			);

			DrawEdge(lps->hDC, &lps->rcItem,
				lps->itemState & ODS_SELECTED ? EDGE_SUNKEN : EDGE_RAISED,
				BF_RECT);

			return TRUE;

		case ID_BTN_MORTY:
			lps = (DRAWITEMSTRUCT*)lParam;
			hFont = (HFONT)SelectObject(lps->hDC, CreateFont(22, 15, 0, 0, FW_BOLD,
				0, 0, 0, 0, 0, 0, PROOF_QUALITY, 0, "Rockwell"));
			GetTextExtentPoint32(lps->hDC, "Morty", 5, &txtSz);

			SetBkColor(lps->hDC, RGB(255, 0, 165));
			SetTextColor(lps->hDC, RGB(84, 0, 54));

			ExtTextOut(lps->hDC,
				(lps->rcItem.right - lps->rcItem.left - txtSz.cx) / 2,
				(lps->rcItem.bottom - lps->rcItem.top - txtSz.cy) / 2,
				ETO_CLIPPED | ETO_OPAQUE, &lps->rcItem, "Morty", 5, NULL
			);

			DrawEdge(lps->hDC, &lps->rcItem,
				lps->itemState & ODS_SELECTED ? EDGE_SUNKEN : EDGE_RAISED,
				BF_RECT);

			return TRUE;

		case ID_BTN_POOP:
			lps = (DRAWITEMSTRUCT*)lParam;
			hFont = (HFONT)SelectObject(lps->hDC, CreateFont(22, 15, 0, 0, FW_BOLD,
				0, 0, 0, 0, 0, 0, PROOF_QUALITY, 0, "Rockwell"));
			GetTextExtentPoint32(lps->hDC, "Mr. Poopybutthole", 17, &txtSz);

			SetBkColor(lps->hDC, RGB(255, 178, 0));
			SetTextColor(lps->hDC, RGB(89, 62, 0));

			ExtTextOut(lps->hDC,
				(lps->rcItem.right - lps->rcItem.left - txtSz.cx) / 2,
				(lps->rcItem.bottom - lps->rcItem.top - txtSz.cy) / 2,
				ETO_CLIPPED | ETO_OPAQUE, &lps->rcItem, "Mr. Poopybutthole", 17, NULL
			);

			DrawEdge(lps->hDC, &lps->rcItem,
				lps->itemState & ODS_SELECTED ? EDGE_SUNKEN : EDGE_RAISED,
				BF_RECT);

			return TRUE;

		case ID_BTN_SUBMIT:
			lps = (DRAWITEMSTRUCT*)lParam;
			hFont = (HFONT)SelectObject(lps->hDC, CreateFont(19, 12, 0, 0, FW_BOLD,
				0, 0, 0, 0, 0, 0, PROOF_QUALITY, 0, "Cooper Black"));
			GetTextExtentPoint32(lps->hDC, "Submit", 6, &txtSz);

			SetBkColor(lps->hDC, RGB(167, 79, 255));
			SetTextColor(lps->hDC, RGB(49, 0, 99));

			ExtTextOut(lps->hDC,
				(lps->rcItem.right - lps->rcItem.left - txtSz.cx) / 2,
				(lps->rcItem.bottom - lps->rcItem.top - txtSz.cy) / 2,
				ETO_CLIPPED | ETO_OPAQUE, &lps->rcItem, "Submit", 6, NULL
			);

			DrawEdge(lps->hDC, &lps->rcItem,
				lps->itemState & ODS_SELECTED ? EDGE_SUNKEN : EDGE_RAISED,
				BF_RECT);

			return TRUE;

		}
		break;

	/* called whenever a paint request was made */
	case WM_PAINT:
		hdc = BeginPaint(hwnd, &ps);

		GetClientRect(hwnd, &rect);

		SetBkMode(hdc, TRANSPARENT);
		SetTextColor(hdc, color);
		DrawText(hdc, txtChosen, -1, &rect, DT_SINGLELINE | DT_CENTER | DT_VCENTER);

		SetTextColor(hdc, RGB(66, 244, 229));
		hFont = (HFONT)SelectObject(hdc, CreateFont(45, 14, 0, 0, FW_HEAVY,
			0, 0, 0, 0, 0, 0, PROOF_QUALITY, FF_DECORATIVE, "Broadway"));
		DrawText(hdc, txtTitle, -1, &rect, DT_SINGLELINE | DT_TOP | DT_CENTER);

		EndPaint(hwnd, &ps);
		break;

	/* called when a window resize is requested */
	case WM_GETMINMAXINFO:
		((MINMAXINFO*)lParam)->ptMinTrackSize.x = 640;
		((MINMAXINFO*)lParam)->ptMinTrackSize.y = 480;
		break;

	/* called when a system command is used */
	case WM_SYSCOMMAND:
		switch (wParam) {

		case SC_MINIMIZE:
			return MessageBox(hwnd, "HEY! DON'T YOU DARE!!", "Minimize Window",
				MB_ICONEXCLAMATION | MB_OK);

		case SC_MAXIMIZE:
			return MessageBox(hwnd, "Lazy dragging the mouse, are we?",
				"Maximize Window", MB_ICONEXCLAMATION | MB_OK);

		case SC_CLOSE:
			if (MessageBox(hwnd,
				"YOU CAN NOT LEAVE THIS PLACE!", "Close Window", MB_YESNO) == IDNO)
				PostQuitMessage(0);
			else
				return MessageBeep(MB_ICONERROR);

		default:
			return DefWindowProc(hwnd, message, wParam, lParam);

		}
		break;

	/* called when a window is destroyed */
	case WM_DESTROY:
		PostQuitMessage(0);
		break;

	/* for messages that we don't deal with */
	default:
		return DefWindowProc(hwnd, message, wParam, lParam);

	}

	return 0;
}
