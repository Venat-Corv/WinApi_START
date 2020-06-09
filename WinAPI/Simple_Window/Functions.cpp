#include "header.h"

BOOL LoadTextFileToEdit(HWND hEdit, LPCTSTR lpszFileName)
{
	BOOL bSuccess = FALSE;
	HANDLE hFile = CreateFile(lpszFileName, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, 0, NULL);
	if (hFile != INVALID_HANDLE_VALUE)
	{
		DWORD dwFileSize = GetFileSize(hFile, NULL);
		if (dwFileSize != UINT_MAX)
		{
			lpszFileText = (LPSTR)GlobalAlloc(GPTR, dwFileSize + 1);
			ZeroMemory(lpszFileText, dwFileSize + 1);
			if (lpszFileText != NULL)
			{
				DWORD dwRead;
				if (ReadFile(hFile, lpszFileText, dwFileSize, &dwRead, NULL))
				{
					if (SetWindowText(hEdit, lpszFileText))
					{
						bSuccess = TRUE;
					}
					GlobalFree(lpszFileText);
				}
			}
			CloseHandle(hFile);
		}
	}
	SetFileNameToStatusBar(hEdit);
	return bSuccess;
}

BOOL SaveFileFromEdit(HWND hEdit, LPCTSTR lpszFileName)
{
	BOOL bSuccess = FALSE;
	HANDLE hFile = CreateFile(lpszFileName, GENERIC_WRITE, 0, NULL, CREATE_ALWAYS, FILE_ATTRIBUTE_NORMAL, NULL);
	if (hFile != INVALID_HANDLE_VALUE)
	{
		DWORD dwTextLength = GetWindowTextLength(hEdit);
		if (dwTextLength)
		{
			lpszFileText = (LPSTR)GlobalAlloc(GPTR, dwTextLength + 1);
			if (lpszFileText)
			{
				if (GetWindowText(hEdit, lpszFileText, dwTextLength + 1))
				{
					DWORD dwWrite;
					if (WriteFile(hFile, lpszFileText, dwTextLength, &dwWrite, NULL))
					{
						bSuccess = TRUE;
					}
					GlobalFree(lpszFileText);
				}
			}
			CloseHandle(hFile);
		}
		SetFileNameToStatusBar(hEdit);
		return bSuccess;
	}
}

BOOL _stdcall DoFileOpen(HWND hwnd)
{
	OPENFILENAME ofn;
	//CHAR szFileName[MAX_PATH]{};
	ZeroMemory(&ofn, sizeof(ofn));

	ofn.lStructSize = sizeof(ofn);
	ofn.hwndOwner = hwnd;
	ofn.lpstrFilter = "Text files: (*.txt)\0*.txt\0All files (*.*)\0*.*\0";
	ofn.lpstrFile = szFileName;
	ofn.nMaxFile = MAX_PATH;
	ofn.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY;
	ofn.lpstrDefExt = "txt";

	if (GetOpenFileName(&ofn))
	{
		LoadTextFileToEdit(GetDlgItem(hwnd, IDC_EDIT), szFileName);
		return TRUE;
	}
	return FALSE;
}

VOID DoFileSaveAs(HWND hwnd)
{
	OPENFILENAME ofn;
	//CHAR szFileName[MAX_PATH]{};

	ZeroMemory(&ofn, sizeof(ofn));

	ofn.lStructSize = sizeof(ofn);
	ofn.hwndOwner = hwnd;
	ofn.lpstrFilter = "Text Files: (*.txt)\0*.txt\0All files: (*.*)\0.*.\0";
	ofn.lpstrFile = szFileName;
	ofn.nMaxFile = MAX_PATH;
	ofn.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT;
	ofn.lpstrDefExt = "txt";

	if (GetSaveFileName(&ofn))
	{
		SaveFileFromEdit(GetDlgItem(hwnd, IDC_EDIT), szFileName);
	}
}

BOOL _stdcall DoFileNew(HWND hwnd)
{
	HWND hEdit = GetDlgItem(hwnd, IDC_EDIT);
	SetWindowText(hEdit, "");
	ZeroMemory(szFileName, sizeof(szFileName));
	if (lpszFileText)
	{
		GlobalFree(lpszFileText);
		lpszFileText = NULL;
	}
	SetFileNameToStatusBar(GetDlgItem(hwnd, IDC_EDIT));
	return TRUE;
}

BOOL FileChanged(HWND hEdit)
{
	BOOL bFileWasChanged = FALSE;
	DWORD dwCurrentTextLength = GetWindowTextLength(hEdit);
	DWORD dwFileTextLength = lpszFileText ? strlen(lpszFileText) : 0;
	if (dwCurrentTextLength != dwFileTextLength)bFileWasChanged = TRUE;
	else
	{
		LPSTR lpszCurrentText = (LPSTR)GlobalAlloc(GPTR, dwCurrentTextLength + 1);
		GetWindowText(hEdit, lpszCurrentText, dwCurrentTextLength + 1);
		if (lpszFileText && strcmp(lpszFileText, lpszCurrentText))bFileWasChanged = TRUE;
		GlobalFree(lpszCurrentText);
	}
	return bFileWasChanged;
}

VOID SetFileNameToStatusBar(HWND hEdit)
{
	CHAR szTitle[MAX_PATH] = "SimpleWindow";
	if (szFileName[0])
	{
		LPSTR szNameOnly = strrchr(szFileName, '\\') + 1;
		strcat_s(szTitle, MAX_PATH, " - ");
		strcat_s(szTitle, MAX_PATH, szNameOnly);
	}
	SendMessage(GetDlgItem(GetParent(hEdit), IDC_STATUS), SB_SETTEXT, 0, (LPARAM)szFileName);
	SetWindowText(GetParent(hEdit), szTitle);
}

VOID WathChanged(HWND hwnd, BOOL(_stdcall* Action)(HWND))
{
	if (FileChanged(GetDlgItem(hwnd, IDC_EDIT)))
	{
		switch (MessageBox(hwnd, "Сохранить изменения в файле?", "Не так быстро...", MB_YESNOCANCEL | MB_ICONQUESTION))
		{
		case IDYES: SendMessage(hwnd, WM_COMMAND, ID_FILE_SAVE, 0);
		case IDNO: Action(hwnd);
		case IDCANCEL: break;
		}
	}
	else
	{
		Action(hwnd);
	}
}

VOID DoSelectFont(HWND hwnd)
{
	CHOOSEFONT cf = { sizeof(CHOOSEFONT) };
	LOGFONT lf;

	GetObject(g_hFont, sizeof(LOGFONT), &lf);

	cf.Flags = CF_EFFECTS | CF_INITTOLOGFONTSTRUCT | CF_SCREENFONTS;
	cf.hwndOwner = hwnd;
	cf.lpLogFont = &lf;
	cf.rgbColors = g_rgbText;

	if (ChooseFont(&cf))
	{
		HFONT hf = CreateFontIndirect(&lf);
		if (hf)
		{
			g_hFont = hf;
			g_rgbText = cf.rgbColors;
		}
		else
		{
			MessageBox(hwnd, "Font create failed!", "Error", MB_OK | MB_ICONERROR);
		}
	}
	SendMessage(GetDlgItem(hwnd, IDC_EDIT), WM_SETFONT, (WPARAM)g_hFont, MAKELPARAM(TRUE,0));
	SendMessage(GetDlgItem(hwnd, IDC_EDIT), WM_CTLCOLOREDIT, g_rgbText, IDC_EDIT);
}