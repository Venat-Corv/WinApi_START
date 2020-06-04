#include "header.h"

LRESULT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE:
	{
		HICON hIcon = (HICON)LoadImage(NULL, "Wolfenstein-5.ico", IMAGE_ICON, 16, 16, LR_LOADFROMFILE);
		SendMessage(hwnd, WM_SETICON, ICON_BIG, (LPARAM)hIcon);

		RECT rcClient;
		GetClientRect(hwnd, &rcClient);

		HWND hEdit = CreateWindowEx
		(
			WS_EX_CLIENTEDGE, "EDIT", "",
			WS_CHILD | WS_VISIBLE | WS_VSCROLL | WS_HSCROLL | ES_MULTILINE | ES_AUTOVSCROLL | ES_AUTOHSCROLL | ES_LEFT,
			0, 0,
			rcClient.right, rcClient.bottom,
			hwnd,
			(HMENU)IDC_EDIT,
			GetModuleHandle(NULL),
			NULL
		);
		SetFocus(hEdit);

		if (szFileName[0])
		{
			
			LoadTextFileToEdit(hEdit, szFileName);
		}
		////////////////Toolbar///////////////
		HWND hTool = CreateWindowEx
		(
			0, TOOLBARCLASSNAME, NULL, WS_CHILD | WS_VISIBLE, 0, 0, 0, 0,
			hwnd, (HMENU)IDC_TOOLBAR, GetModuleHandle(NULL), NULL
		);
		SendMessage(hTool, TB_BUTTONSTRUCTSIZE, (WPARAM)sizeof(TBBUTTON), 0);

		TBBUTTON tbb[3]{};
		TBADDBITMAP tbab;
		tbab.hInst = HINST_COMMCTRL;
		tbab.nID = IDB_STD_SMALL_COLOR;
		SendMessage(hTool, TB_ADDBITMAP, 0, (LPARAM)&tbab);

		/*tbb[0].iBitmap = STD_FILENEW;
		tbb[0].fsState = TBSTATE_ENABLED;
		tbb[0].fsStyle = TBSTYLE_BUTTON;
		tbb[0].idCommand = ID_FILE_NEW;

		tbb[1].iBitmap = STD_FILEOPEN;
		tbb[1].fsState = TBSTATE_ENABLED;
		tbb[1].fsStyle = TBSTYLE_BUTTON;
		tbb[1].idCommand = ID_FILE_OPEN;

		tbb[2].iBitmap = STD_FILESAVE;
		tbb[2].fsState = TBSTATE_ENABLED;
		tbb[2].fsStyle = TBSTYLE_BUTTON;
		tbb[2].idCommand = ID_FILE_SAVE;*/

		for (int i = 0; i < sizeof(tbb) / sizeof(TBBUTTON); i++)
		{
			tbb[i].iBitmap = STD_FILENEW + i;
			tbb[i].fsState = TBSTATE_ENABLED;
			tbb[i].fsStyle = TBSTYLE_BUTTON;
			tbb[i].idCommand = ID_FILE_NEW + i;
		}

		SendMessage(hTool, TB_ADDBUTTONS, sizeof(tbb) / sizeof(TBBUTTON), (LPARAM)&tbb);
		//////////////////////////////////////

		/////////////////////////////////////
		//////////   Status Bar   ///////////

		HWND hStatus = CreateWindowEx
		(
			0, STATUSCLASSNAME, NULL, WS_CHILD | WS_VISIBLE | SBARS_SIZEGRIP, 0, 0, 0, 0,
			hwnd, (HMENU)IDC_STATUS, GetModuleHandle(NULL), NULL
		);

		int statwidth[] = { 300, -1 };
		SendMessage(hStatus, SB_SETPARTS, sizeof(statwidth) / sizeof(int), (LPARAM)statwidth);
		SendMessage(hStatus, SB_SETTEXT, 0, (LPARAM)(szFileName[0]?szFileName:"No file"));

		/////////////////////////////////////

		RegisterHotKey(hwnd, HOTKEY_NEW, MOD_CONTROL, 'N');
		RegisterHotKey(hwnd, HOTKEY_OPEN, MOD_CONTROL, 'O');
		RegisterHotKey(hwnd, HOTKEY_SAVE, MOD_CONTROL, 'S');
		RegisterHotKey(hwnd, HOTKEY_SAVEAS, MOD_CONTROL+MOD_ALT, 'S');
		RegisterHotKey(hwnd, HOTKEY_ABOUT, 0, VK_F1);

		HDC hdc = GetDC(NULL);
		long lfHeight = -MulDiv(16, GetDeviceCaps(hdc, LOGPIXELSY), 72);
		ReleaseDC(NULL, hdc);

		HFONT hf = CreateFont(
			lfHeight,
			0, 0, 0, 0,
			TRUE, 0, 0,
			0, 0, 0, 0, 0,
			"Times New Roman"
		);
		SendMessage(hEdit, WM_SETFONT, (WPARAM)hf, 0);

	}
	break;
	case WM_SIZE:
	{
		/*RECT rcClient;
		GetClientRect(hwnd, &rcClient);
		SetWindowPos(GetDlgItem(hwnd, IDC_EDIT), NULL, 0, 0, rcClient.right, rcClient.bottom, SWP_NOZORDER);*/

		HWND hTool = GetDlgItem(hwnd, IDC_TOOLBAR);
		SendMessage(hTool, TB_AUTOSIZE, 0, 0);
		RECT rcTool;
		GetWindowRect(hTool, &rcTool);
		int iToolbarHeight = rcTool.bottom - rcTool.top;

		HWND hStatus = GetDlgItem(hwnd, IDC_STATUS);
		SendMessage(hStatus, WM_SIZE, 0, 0);
		RECT rcStatus;
		GetWindowRect(hStatus, &rcStatus);
		int iStatusHeight = rcStatus.bottom - rcStatus.top;

		HWND hEdit = GetDlgItem(hwnd, IDC_EDIT);
		RECT rcClient;
		GetClientRect(hwnd, &rcClient);
		int iEditHeight = rcClient.bottom - iToolbarHeight - iStatusHeight;
		SetWindowPos(hEdit, NULL, 0, iToolbarHeight, rcClient.right, iEditHeight, SWP_NOZORDER);
	}
	break;
	case WM_DROPFILES:
	{
		HDROP hDrop = (HDROP)wParam;
		DragQueryFile(hDrop, 0, szFileName, MAX_PATH);
		LoadTextFileToEdit(GetDlgItem(hwnd, IDC_EDIT), szFileName);
		DragFinish(hDrop);
	}
		break;
	case WM_COMMAND:
	{
		switch (LOWORD(wParam))
		{
		case ID_FILE_OPEN:
		{
			WathChanged(hwnd, DoFileOpen);
		}
		break;
		case ID_FILE_SAVEAS:
		{
			DoFileSaveAs(hwnd);
		}
		break;
		case ID_FILE_SAVE:
		{
			if (szFileName[0])
			{
				SaveFileFromEdit(GetDlgItem(hwnd, IDC_EDIT), szFileName);
			}
			else
			{
				SendMessage(hwnd, WM_COMMAND, ID_FILE_SAVEAS, 0);
			}
		}
		break;
		case ID_FILE_EXIT:
		{
			DestroyWindow(hwnd);
		}
		break;
		case ID_HELP_ABOUT:
		{
			DialogBox(GetModuleHandle(NULL), MAKEINTRESOURCE(IDD_DIALOG1), hwnd, DlgProc, 0);
		}
		break;
		}
	}
	break;
	case WM_HOTKEY:
	{
		switch (wParam)
		{
		case HOTKEY_NEW:
			SendMessage(hwnd, WM_COMMAND, ID_FILE_NEW, 0);
			break;
		case HOTKEY_OPEN:
			SendMessage(hwnd, WM_COMMAND, ID_FILE_OPEN, 0);
			break;
		case HOTKEY_SAVE:
			SendMessage(hwnd, WM_COMMAND, ID_FILE_SAVE, 0);
			break;
		case HOTKEY_SAVEAS:
			SendMessage(hwnd, WM_COMMAND, ID_FILE_SAVEAS, 0);
			break;
		case HOTKEY_ABOUT:
			SendMessage(hwnd, WM_COMMAND, ID_HELP_ABOUT, 0);
			break;
		}
	}
		break;
	case WM_CLOSE:
		WathChanged(hwnd, DestroyWindow);
		break;
	case WM_DESTROY:
		MessageBox(hwnd, "—паcибо за то что выбрали наш редактор", "Info", MB_OK);
		PostQuitMessage(0);
	default:return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return 0;
}