#include<Windows.h>
#include"resource.h"

//HWND hEdit1;
//HWND hEdit2;

CHAR str1[] = "Hello gues ;-)";
CHAR str2[] = { 0 };

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
		HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);

		/*hEdit1 = GetDlgItem(hwnd, IDC_EDIT1);
		hEdit2 = GetDlgItem(hwnd, IDC_EDIT2);

		SendMessage(hEdit1, WM_SETTEXT, 0, (LPARAM)str1);*/
		SetDlgItemText(hwnd, IDC_EDIT1, str1);

		SetFocus(GetDlgItem(hwnd, IDC_COPY));
	}
	break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
			MessageBox(hwnd, "Hell", "Hi", MB_OK);
			break;
		case IDCANCEL:
			EndDialog(hwnd, 0);
		case IDC_COPY:
			GetDlgItemText(hwnd, IDC_EDIT1, str2, 255);
			SetDlgItemText(hwnd, IDC_EDIT2, str2);
			/*SendMessage(hEdit1, WM_GETTEXT, 255, (LPARAM)str2);
			SendMessage(hEdit2, WM_SETTEXT, 0, (LPARAM)str2);*/
			break;
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
		break;
	}
	return FALSE;
}