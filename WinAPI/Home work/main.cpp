#include <Windows.h>
#include <TCHAR.H>
#include <Strsafe.h>
#include "resource.h"

TCHAR user_name[] = TEXT("User");
TCHAR hello[] = TEXT("Hello ");

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, int nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, DlgProc, 0);
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		SetFocus(GetDlgItem(hwnd, IDC_EDIT1));
	}
	break;
	case WM_COMMAND:
	{
		switch (LOWORD(wParam))
		{
		case IDC_SEND:
			GetDlgItemText(hwnd, IDC_EDIT1, user_name, 255);
			StringCchCat(hello, 512, user_name);
			MessageBox(hwnd, hello, "Hello", MB_OK);
			break;
		}
	}
	break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}
	return 0;
}