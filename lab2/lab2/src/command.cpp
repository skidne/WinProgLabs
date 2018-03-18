#include "header.h"

void wmCommand(WPARAM wParam, HWND hwnd, HINSTANCE hInst) {
	switch (wParam) {

	case ID_BTN_DOME:
		CreateWindowEx(WS_EX_DLGMODALFRAME | WS_EX_TOPMOST, "DialogClass",
			"What would you like for dinner?",
			WS_VISIBLE | WS_SYSMENU | WS_CAPTION, 100, 100, 300, 200,
			NULL, NULL, hInst, NULL);
		break;

	case ID_ABOUT_VOLDEMORT:
		MessageBox(hwnd, "AVADA KEDAVRA", "Voldemort", MB_OK);
		break;

	case ID_ABOUT_PIZZA:
		MessageBox(hwnd, "The only dish teenage mutant ninja turtles love.", "Pizza", MB_OK);
		break;

	case ID_ABOUT_FUNGI:
		MessageBox(hwnd, "If it's red and has white spots, you should totally eat it.", "Fungi", MB_OK);
		break;

	case ID_GOD_HELP_ME:
		MessageBox(hwnd, "After reading this, you will have 30 seconds to cry out loud \"I'm gay\","
			" otherwise you will die a horrible death.", "No help from God", MB_OK);
		break;
	}
}