#include <Windows.h>
#include<string>
#include "resource.h"

double a = 0;
double b = 0;
CHAR buffer[256]{};
char sign;

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
VOID count(HWND hEdit, double& a, char s, double& b);

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, int cmdShow)
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
		
		SetFocus(hEdit);
	}
		break;
	case WM_COMMAND:
		switch (LOWORD (wParam))
		{
		case IDCBTN0: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x30, 0); break;
		case IDCBTN1: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x31, 0); break;
		case IDCBTN2: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x32, 0); break;
		case IDCBTN3: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x33, 0); break;
		case IDCBTN4: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x34, 0); break;
		case IDCBTN5: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x35, 0); break;
		case IDCBTN6: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x36, 0); break;
		case IDCBTN7: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x37, 0); break;
		case IDCBTN8: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x38, 0); break;
		case IDCBTN9: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 0x39, 0); break;
		case IDCBTNDOUB: SendMessage(GetDlgItem(hwnd, IDC_EDIT1), WM_CHAR, 46, 0); break;
		case IDCBTNPLUS:
		{
			HWND hEdit = GetDlgItem(hwnd, IDC_EDIT1);
			sign = '+';
			count(hEdit, a, sign, b);
		}
		break;
		case IDCBTNRES:
		{

		}
		break;
		}
		break;
	case WM_CLOSE:
			EndDialog(hwnd, 0);
			break;
	}
	return FALSE;
}

VOID count(HWND hEdit, double& a, char s, double& b)
{
	if (a == 0)
	{
		a = atof(buffer);
	}
	else
	{
		b = atof(buffer);
		switch (s)
		{
		case '+': a += b; break;
		case '-': a -= b; break;
		case '*': a *= b; break;
		case '/': a /= b; break;
		}
		strcpy(buffer, std::to_string(a).c_str());

		SetWindowText(hEdit, buffer);

	}
	if (b == 0)SetWindowText(hEdit, "");
	
}